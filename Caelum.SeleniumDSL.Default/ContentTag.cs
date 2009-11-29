using Caelum.SeleniumDSL.Selector;
using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class ContentTag : IContentTag
    {
        private readonly ISelenium _selenium;
        private readonly string _id;

        public ContentTag(ISelenium selenium, ISelector selector)
        {
            _selenium = selenium;
            _id = string.Format("//*{0}", selector.GetExpression());
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