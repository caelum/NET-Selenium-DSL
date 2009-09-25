namespace Caelum.SeleniumDSL.Table
{
    public interface IColumn
    {
        bool Contains(string text);

        bool ContainsPartial(string value);

        int Find(string text);
    }
}
