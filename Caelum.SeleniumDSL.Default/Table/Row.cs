using System;
using Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL.Default.Table
{
    internal class Row : IRow
    {
        private readonly Table _table;
        private readonly int _index;

        public Row(Table table, int index)
        {
            _table = table;
            _index = index;
        }

        public ICell Cell(int column)
        {
            return new Cell(_table, _index, column);
        }

        public ICell Cell(string column)
        {
            return new Cell(_table, _index, _table.FindColumn(column));
        }

        public int Index()
        {
            return _index;
        }

        public string Xpath
        {
            get { throw new NotImplementedException(); }
        }
    }
}
