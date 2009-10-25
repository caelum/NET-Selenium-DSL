using Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL.Default.Table
{
    internal class Column : IColumn
    {
        private readonly ITable _table;
        private readonly int _columnNumber;

        public Column(ITable table, int columnNumber)
        {
            _table = table;
            _columnNumber = columnNumber;
        }

        public bool Contains(string text)
        {
            return Find(text) != -1;
        }

        public bool ContainsPartial(string value)
        {
            return Find(value) >= 0;
        }

        public int Find(string text)
        {
            int rowCount = _table.GetRowCount();
            for (int i = 0; i < rowCount; i++)
                if (_table.Cell(i, _columnNumber).Contains(text))
                    return i;
            return -1;
        }
    }
}