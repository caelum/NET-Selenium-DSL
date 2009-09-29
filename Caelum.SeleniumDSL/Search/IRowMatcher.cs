using Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL.Search
{
    public interface IRowMatcher
    {
        void SetTable(ITable table);

        IRow Next();
    }
}