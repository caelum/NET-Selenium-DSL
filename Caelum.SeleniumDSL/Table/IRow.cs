namespace Caelum.SeleniumDSL.Table
{
    public interface IRow
    {
        ICell Cell(int column);

        ICell Cell(string column);

        int Index();
    }
}
