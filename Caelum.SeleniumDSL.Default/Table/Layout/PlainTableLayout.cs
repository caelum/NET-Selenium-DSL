using Caelum.SeleniumDSL.Table;
using Caelum.SeleniumDSL.Table.Layout;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Table.Layout
{
    internal class PlainTableLayout : ITableLayout
    {
        private readonly ISelenium selenium;
        private readonly string tableXPath;
        private readonly string headerXPath;

        public PlainTableLayout(ISelenium selenium, string id)
        {
            this.selenium = selenium;
            this.tableXPath = string.Format("//table[@id='{0}']/tbody", id);
            this.headerXPath = tableXPath + "/tr[1]";
        }

        public string HeaderValue(int column)
        {
            return this.selenium.GetText(this.headerXPath + string.Format("/td[{0}]", column));
        }

        public string HeaderLinkValue(int column)
        {
            return this.selenium.GetText(this.headerXPath + string.Format("/td[{0}]/a/text()", column));
        }

        public int GetContentCount()
        {
            return (int) selenium.GetXpathCount(this.tableXPath + "/tr") - 1;
        }

        public string Value(int row, int column)
        {
            row += 1;
            return this.selenium.GetText(this.tableXPath + string.Format("/tr[{0}]/td[{1}]", row, column));
        }

        public int GetColumnCount()
        {
            return (int) selenium.GetXpathCount(this.tableXPath + "/tr[1]/td");
        }

        public int GetRowCount()
        {
            return (int) selenium.GetXpathCount(this.tableXPath + "/tr");
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