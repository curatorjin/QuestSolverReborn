using Lumina;
using Lumina.Excel;
using Lumina.Excel.Sheets;
using Lumina.Text.ReadOnly;

namespace QuestSolverReborn.Data;

[Sheet("Quest")]
public readonly struct QuestWithTodo(RawRow row) : IExcelRow<QuestWithTodo>
{
    public uint data0_0 => row.ReadUInt16(1222);
    
    public uint data0_1 => row.ReadUInt16(1246);
    public uint data0_2 => row.ReadUInt16(1270);
    public uint data0_3 => row.ReadUInt16(1294);
    public uint data0_4 => row.ReadUInt16(1318);
    public uint data0_5 => row.ReadUInt16(1342);
    public uint data0_6 => row.ReadUInt16(1366);
    public uint data0_7 => row.ReadUInt16(1390);
    public uint data1_0 => row.ReadUInt16(1223);
    public uint data1_1 => row.ReadUInt16(1247);
    public uint data1_2 => row.ReadUInt16(1271);
    public uint data1_3 => row.ReadUInt16(1295);
    public uint data1_4 => row.ReadUInt16(1319);
    public uint data1_5 => row.ReadUInt16(1343);
    public uint data1_6 => row.ReadUInt16(1367);
    public uint data1_7 => row.ReadUInt16(1391);
    
    public uint RowId { get; }

    public static QuestWithTodo Create(ExcelPage page, uint offset, uint row) => new(new(page, offset, row));
}
