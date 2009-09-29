using Caelum.SeleniumDSL.Search;

namespace Caelum.SeleniumDSL.Table
{
    public interface ITable
    {
        string GetType();

        IColumn Column(int columnIndex);

        IColumn Column(string columnName);

        int GetColumnCount();

        int GetRowCount();

        int GetContentCount();

        IRow Header();

        IRow Row(int row);

        ICell Cell(int row, int column);

        ICell Cell(int row, string column);

        string GetId();

        bool Exists();

        void Iterate(IRowVisitor visitor);

        int FindColumn(string columnName);

        IRowMatcher Select(IRowMatcher matcher);

        //ITableCriteria CreateCriteria();

        //ITableLayout GetLayout();
    }
}