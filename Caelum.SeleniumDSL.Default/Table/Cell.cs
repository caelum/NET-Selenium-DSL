using System;
using Caelum.SeleniumDSL.Table;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Table
{
    internal class Cell : ICell
    {
        private ISelenium _selenium;
        private ITable _table;
        private int _row;
        private int _column;

        public Cell(ISelenium selenium, ITable table, int row, int column)
        {
            _selenium = selenium;
            _table = table;
            _row = row;
            _column = column;
        }

        public string Value()
        {
            throw new NotImplementedException();
        }

        public string GetLink()
        {
            throw new NotImplementedException();
        }

        public string HeaderValue()
        {
            throw new NotImplementedException();
        }

        public string HeaderLinkValue()
        {
            throw new NotImplementedException();
        }

        public ICell Check()
        {
            throw new NotImplementedException();
        }

        public ICell Uncheck()
        {
            throw new NotImplementedException();
        }

        public bool Checked()
        {
            throw new NotImplementedException();
        }

        public bool Contains(string content)
        {
            throw new NotImplementedException();
        }
    }
}