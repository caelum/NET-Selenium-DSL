using Selenium;

namespace Caelum.SeleniumDSL.Default.Table.Layout
{
    internal class TableLayoutChooser
    {
        private readonly ISelenium _selenium;
        private readonly string _id;

        public TableLayoutChooser(ISelenium selenium, string id)
        {
            _selenium = selenium;
            _id = id;
        }

        public ITableLayout GetLayout()
        {
            decimal theads = _selenium.GetXpathCount(string.Format("id('{0}')/thead", _id));
            decimal ths = _selenium.GetXpathCount(string.Format("id('{0}')//th", _id)); // should'nt be id('')/tr[0]/th??

            if (theads > 0 && ths > 0)
                return new FullTableLayout(_selenium, _id);

            if (theads == 0 && ths > 0)
                return new PlainTablePlusThLayout(_selenium, _id);

            return new PlainTableLayout(_selenium, _id);
        }
    }
}
