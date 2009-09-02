using Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL.Search
{
    public interface IRowVisitor
    {
        void Visit(IRow Row);
    }
}
