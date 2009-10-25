using Caelum.SeleniumDSL.Table.Layout;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Table.Layout
{
    internal class FullTableLayout : ITableLayout
    {
        private readonly ISelenium _selenium;
        private readonly string _tableXPath;
        private readonly string _headerXPath;

        public FullTableLayout(ISelenium selenium, string id)
        {
            _selenium = selenium;
            _tableXPath = string.Format("//table[@id='{0}']", id);
            _headerXPath = _tableXPath + "/thead/tr[1]";
        }

        public string HeaderValue(int column)
        {
            return _selenium.GetText(_headerXPath + string.Format("/th[{0}]", column));
        }

        public string HeaderLinkValue(int column)
        {
            return _selenium.GetText(_headerXPath + string.Format("/th[{0}]/a/text()", column));
        }

        public int GetContentCount()
        {
            return (int) _selenium.GetXpathCount(_tableXPath + "/tbody/tr");
        }

        public string Value(int row, int column)
        {
            return _selenium.GetText(_tableXPath + string.Format("/tbody/tr[{0}]/td[{1}]", row, column));
        }

        public int GetColumnCount()
        {
            return (int) _selenium.GetXpathCount(_tableXPath + "/thead/tr/th");
        }

        public int GetRowCount()
        {
            return (int) _selenium.GetXpathCount(_tableXPath + "/*/tr");
        }

    }
}