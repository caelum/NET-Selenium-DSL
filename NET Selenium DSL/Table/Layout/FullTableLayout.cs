using System;
using System.Collections.Generic;
using System.Text;
using Selenium;

namespace Caelum.SeleniumDSL.Table.Layout
{
    internal class FullTableLayout : ITableLayout
    {
        private ISelenium selenium;
        private string xPath;

        public FullTableLayout(ISelenium selenium, string id)
        {
            this.selenium = selenium;
            this.xPath = string.Format("//table[@id='{0}']", id);
        }

        public string HeaderValue(int column)
        {
            return this.selenium.GetText(this.xPath + string.Format("/thead/tr[1]/th[{0}]", column));
        }

        public string HeaderLinkValue(int Column)
        {
            throw new NotImplementedException();
        }

        public int GetContentCount()
        {
            return (int)selenium.GetXpathCount(this.xPath + "/tbody/tr");
        }

        public string Value(int row, int column)
        {
            return this.selenium.GetText(this.xPath + string.Format("/tbody/tr[{0}]/th[{1}]", row, column));
        }

        public int GetColumnCount()
        {
            return (int)selenium.GetXpathCount(this.xPath + "/thead/tr/th");
        }

        public int GetRowCount()
        {
            return (int)selenium.GetXpathCount(this.xPath + "/*/tr");
        }

        public bool Contains(ITable table, string column, string content)
        {
            for (int i = 1; i < GetRowCount(); i++)
            {
                if (table.Cell(i, column).Contains(content))
                    return true;
            }
            return false;
        }
    }
}