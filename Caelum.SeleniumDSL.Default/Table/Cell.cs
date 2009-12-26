using System;
using Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL.Default.Table
{
    internal class Cell : ICell
    {
        private readonly Table _table;
        private readonly int _row;
        private readonly int _column;

        public Cell(Table table, int row, int column)
        {
            _table = table;
            _row = row;
            _column = column;
        }

        public string Value()
        {
            return _table.Layout.Value(_row, _column);
        }   

        public bool Contains(string text)
        {
            return _table.Layout.Value(_row, _column).Contains(text);
        }

        public string Xpath
        {
            get { throw new NotImplementedException(); }
        }
    }
}