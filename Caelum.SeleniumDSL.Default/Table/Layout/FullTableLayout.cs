using Caelum.SeleniumDSL.Table;
using Caelum.SeleniumDSL.Table.Layout;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Table.Layout
{
    internal class FullTableLayout : ITableLayout
    {
        private readonly ISelenium selenium;
        private readonly string tableXPath;
        private readonly string headerXPath;

        public FullTableLayout(ISelenium selenium, string id)
        {
            this.selenium = selenium;
            this.tableXPath = string.Format("//table[@id='{0}']", id);
            this.headerXPath = tableXPath + "/thead/tr[1]";
        }

        public string HeaderValue(int column)
        {
            return this.selenium.GetText(this.headerXPath + string.Format("/th[{0}]", column));
        }

        public string HeaderLinkValue(int column)
        {
            return this.selenium.GetText(this.headerXPath + string.Format("/th[{0}]/a/text()", column));
        }

        public int GetContentCount()
        {
            return (int) selenium.GetXpathCount(this.tableXPath + "/tbody/tr");
        }

        public string Value(int row, int column)
        {
            return this.selenium.GetText(this.tableXPath + string.Format("/tbody/tr[{0}]/td[{1}]", row, column));
        }

        public int GetColumnCount()
        {
            return (int) selenium.GetXpathCount(this.tableXPath + "/thead/tr/th");
        }

        public int GetRowCount()
        {
            return (int) selenium.GetXpathCount(this.tableXPath + "/*/tr");
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