﻿using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using InteropGenerator.Extensions;
using InteropGenerator.Helpers;
using InteropGenerator.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace InteropGenerator.Generator;

public sealed partial class InteropGenerator {

    private static StructInfo ParseStructInfo(INamedTypeSymbol structSymbol, CancellationToken token) {
        // collection info on struct methods
        ParseMethods(structSymbol, token, out EquatableArray<MemberFunctionInfo> memberFunctions, out EquatableArray<StaticAddressInfo> staticAddresses);
        token.ThrowIfCancellationRequested();
        
        // get containing types; our analyzer validates structs are contained in a proper hierachy so not needed here
        using ImmutableArrayBuilder<string> hierarchy = new();

        for (INamedTypeSymbol? parent = structSymbol;
             parent is not null;
             parent = parent.ContainingType) {
            hierarchy.Add(parent.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat));
        }
           
        // collect all info
        return new StructInfo(
            structSymbol.GetFullyQualifiedMetadataName(),
            structSymbol.ContainingNamespace.ToDisplayString(
                new SymbolDisplayFormat(typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces)),
            hierarchy.ToImmutable(),
            memberFunctions,
            staticAddresses);
    }

    private static void ParseMethods(INamedTypeSymbol structSymbol, CancellationToken token, out EquatableArray<MemberFunctionInfo> memberFunctions, out EquatableArray<StaticAddressInfo> staticAddresses) {
        using ImmutableArrayBuilder<MemberFunctionInfo> memberFunctionsBuilder = new();
        using ImmutableArrayBuilder<StaticAddressInfo> staticAdddressesBuilder = new();

        foreach (IMethodSymbol methodSymbol in structSymbol.GetMembers().OfType<IMethodSymbol>()) {
            if (methodSymbol.TryGetAttributeWithFullyQualifiedMetadataName(AttributeNames.MemberFunctionAttribute, out AttributeData? mfAttribute)) {
                if (mfAttribute.ConstructorArguments.Length != 2 ||
                    !mfAttribute.TryGetConstructorArgument(0, out string? signature) ||
                    !mfAttribute.TryGetConstructorArgument(1, out byte? offset))
                    continue; // ignore malformed attribute

                if (!TryParseMethod(methodSymbol, token, out MethodInfo? methodInfo))
                    continue;

                MemberFunctionInfo mfi = new MemberFunctionInfo(
                    methodInfo,
                    signature,
                    offset.Value);

                memberFunctionsBuilder.Add(mfi);
            }
            else if (methodSymbol.TryGetAttributeWithFullyQualifiedMetadataName(AttributeNames.StaticAddressAttribute, out AttributeData? saAttribute)) {
                if (saAttribute.ConstructorArguments.Length != 3 ||
                    !saAttribute.TryGetConstructorArgument(0, out string? signature) ||
                    !saAttribute.TryGetConstructorArgument(1, out byte? offset) ||
                    !saAttribute.TryGetConstructorArgument(2, out bool? isPointer))
                    continue; // ignore malformed attribute
                
                if (!TryParseMethod(methodSymbol, token, out MethodInfo? methodInfo))
                    continue;

                StaticAddressInfo sai = new StaticAddressInfo(
                    methodInfo,
                    signature,
                    offset.Value,
                    isPointer.Value);

                staticAdddressesBuilder.Add(sai);
            }
            
            token.ThrowIfCancellationRequested();
        }
        memberFunctions = memberFunctionsBuilder.ToImmutable();
        staticAddresses = staticAdddressesBuilder.ToImmutable();
    }

    private static bool TryParseMethod(IMethodSymbol methodSymbol, CancellationToken token, [NotNullWhen(true)] out MethodInfo? methodInfo) {
        if (!methodSymbol.TryGetSyntaxNode(token, out MethodDeclarationSyntax? methodSyntax)) {
            methodInfo = null;
            return false; // unable to get method syntax
        }

        methodInfo =
            new MethodInfo(
                methodSymbol.Name,
                methodSyntax.Modifiers.ToString(),
                methodSymbol.ReturnType.GetFullyQualifiedName(),
                methodSymbol.IsStatic,
                methodSymbol.Parameters.Select(ParseParameter).ToImmutableArray()
            );

        return true;
    }

    private static ParameterInfo ParseParameter(IParameterSymbol parameterSymbol) {
        return new ParameterInfo(
            parameterSymbol.Name,
            parameterSymbol.Type.GetFullyQualifiedName(),
            parameterSymbol.GetDefaultValueString(),
            parameterSymbol.RefKind);
    }
}
