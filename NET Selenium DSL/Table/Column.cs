using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Selenium;

namespace Caelum.SeleniumDSL.Table
{
    internal class Column : IColumn
    {
        private ISelenium selenium;
        private int columnNumber;

        public Column(ISelenium selenium, int columnNumber)
        {
            this.selenium = selenium;
            this.columnNumber = columnNumber;
        }

        public bool Contains(string Text)
        {
            throw new NotImplementedException();
        }

        public bool ContainsPartial(string Value)
        {
            throw new NotImplementedException();
        }

        public int Find(string Text)
        {
            throw new NotImplementedException();
        }

    }
}
