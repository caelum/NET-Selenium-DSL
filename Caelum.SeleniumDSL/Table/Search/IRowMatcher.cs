namespace Caelum.SeleniumDSL.Table.Search
{
    public interface IRowMatcher
    {
        void SetTable(ITable table);

        IRow Next();
    }
}