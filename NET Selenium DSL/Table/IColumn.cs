namespace Caelum.SeleniumDSL.Table
{
    public interface IColumn
    {
        bool Contains(string Text);

        bool ContainsPartial(string Value);

        int Find(string Text);
    }
}
