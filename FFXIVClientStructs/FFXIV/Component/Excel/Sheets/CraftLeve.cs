// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x24)]
public unsafe partial struct CraftLeve {
    /// <remarks>Leve</remarks>
    [FieldOffset(0x00)] public int Leve;
    /// <remarks>CraftLeveTalk</remarks>
    [FieldOffset(0x04)] public int CraftLeveTalk;
    [FieldOffset(0x08), FixedSizeArray] internal FixedSizeArray4<int> _item;
    [FieldOffset(0x18), FixedSizeArray] internal FixedSizeArray4<ushort> _itemCount;
    [FieldOffset(0x20)] public byte Repeats;
}