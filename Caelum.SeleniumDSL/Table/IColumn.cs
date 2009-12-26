namespace Caelum.SeleniumDSL.Table
{
    public interface IColumn : IElement
    {
        bool Contains(string text);

        int FindRow(string text);
    }
}