using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class ContentTag : IContentTag
    {
        private readonly ISelenium _selenium;
        private readonly string _id;

        public ContentTag(ISelenium selenium, string id)
        {
            _selenium = selenium;
            _id = id;
        }

        public bool Contains(string content)
        {
            return _selenium.GetText(_id).Contains(content);
        }

        public bool Exists()
        {
            return _selenium.IsElementPresent(_id);
        }

        public string InnerHtml()
        {
            return _selenium.GetText(_id);
        }
    }
}