using System;
using Caelum.SeleniumDSL.Table;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Table
{
    internal class Cell : ICell
    {
        private ISelenium selenium;
        private ITable table;
        private int row;
        private int column;

        public Cell(ISelenium selenium, ITable table, int row, int column)
        {
            this.selenium = selenium;
            this.table = table;
            this.row = row;
            this.column = column;
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