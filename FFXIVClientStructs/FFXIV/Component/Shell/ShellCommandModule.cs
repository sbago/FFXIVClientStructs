using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Client.UI.Misc;
using FFXIVClientStructs.FFXIV.Component.Excel;
using FFXIVClientStructs.FFXIV.Component.Text;

namespace FFXIVClientStructs.FFXIV.Component.Shell;

[StructLayout(LayoutKind.Explicit, Size = 0x250)]
public unsafe struct ShellCommandModule {
    [FieldOffset(0x38)] public ExcelModuleInterface* ExcelModuleInterface;
    [FieldOffset(0x40)] public RaptureTextModule* RaptureTextModule;
    [FieldOffset(0x48)] public TextChecker TextChecker;
    [FieldOffset(0x140)] public ShellCommands ShellCommands;
    [FieldOffset(0x168)] public Utf8String CurrentChannel;
    [FieldOffset(0x1E0)] public Utf8String CommandSheetName;
    [FieldOffset(0x248)] public byte CommandColumn;
    [FieldOffset(0x249)] public byte AliasColumn;
}
