using Caelum.SeleniumDSL.Table;
using Caelum.SeleniumDSL.Search;

namespace Caelum.SeleniumDSL
{
    public interface ITable
    {
        string GetType();

        IColumn Column(int ColumnIndex);

        IColumn Column(string ColumnName);

        int GetColCount();

        int GetRowCount();

        int GetContentCount();

        IRow Header();

        IRow Row(int Row);

        ICell Cell(int Row, int Col);

        ICell Cell(int Row, string Col);

        string GetId();

        bool Exists();

        void Iterate(IRowVisitor Visitor);

        int FindColumn(string ColumnName);

        IRowMatcher Select(IRowMatcher Matcher);

        //ITableCriteria CreateCriteria();

        //ITableLayout GetLayout();
    }
}
