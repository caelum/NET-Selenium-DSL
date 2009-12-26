namespace Caelum.SeleniumDSL.Table
{
    public interface IRow : IElement
    {
        ICell Cell(int column);

        ICell Cell(string column);

        int Index();
    }
}