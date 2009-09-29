using Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL.Default.Table
{
    internal class Column : IColumn
    {
        private ITable table;
        private int columnNumber;

        public Column(ITable table, int columnNumber)
        {
            this.table = table;
            this.columnNumber = columnNumber;
        }

        public bool Contains(string text)
        {
            return Find(text) != -1;
        }

        // TODO: implement XPath search
        public bool ContainsPartial(string value)
        {
            int rowCount = table.GetRowCount();
            for (int i = 0; i < rowCount; i++)
                if (table.Cell(i, columnNumber).Contains(value))
                    return true;
            return false;
        }

        // TODO: implement XPath search
        public int Find(string text)
        {
            int rowCount = table.GetRowCount();
            for (int i = 0; i < rowCount; i++)
                if (table.Cell(i, columnNumber).Contains(text))
                    return i;
            return -1;
        }
    }
}