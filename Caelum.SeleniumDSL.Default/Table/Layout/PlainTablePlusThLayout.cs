using Caelum.SeleniumDSL.Table.Layout;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Table.Layout
{
    internal class PlainTablePlusThLayout : ITableLayout
    {
        private readonly ISelenium _selenium;
        private readonly string _tableXPath;
        private readonly string _headerXPath;

        public PlainTablePlusThLayout(ISelenium selenium, string id)
        {
            _selenium = selenium;
            _tableXPath = string.Format("//table[@id='{0}']/tbody", id);
            _headerXPath = _tableXPath + "/tr[1]";
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
            return (int) _selenium.GetXpathCount(_tableXPath + "/tr") - 1;
        }

        public string Value(int row, int column)
        {
            return _selenium.GetText(_tableXPath + string.Format("/tr[{0}]/td[{1}]", row + 1, column));
        }

        public int GetColumnCount()
        {
            return (int) _selenium.GetXpathCount(_tableXPath + "/tr[1]/th");
        }

        public int GetRowCount()
        {
            return (int) _selenium.GetXpathCount(_tableXPath + "/tr");
        }

    }
}