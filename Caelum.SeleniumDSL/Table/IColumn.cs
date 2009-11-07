namespace Caelum.SeleniumDSL.Table
{
    public interface IColumn
    {
        bool Contains(string text);

        int FindRow(string text);
    }
}