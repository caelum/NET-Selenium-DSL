using System;
using Caelum.SeleniumDSL.Selector;
using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class ContentTag : IContentTag
    {
        private readonly ISelenium _selenium;
        private readonly string _xpath;

        public ContentTag(ISelenium selenium, ISelector selector)
        {
            _selenium = selenium;
            _xpath = string.Format("//*{0}", selector.GetExpression());
        }

        public bool Contains(string content)
        {
            return _selenium.GetText(_xpath).Contains(content);
        }

        public bool Exists()
        {
            return _selenium.IsElementPresent(_xpath);
        }

        public string InnerHtml()
        {
            return _selenium.GetText(_xpath);
        }

        public string Xpath
        {
            get { return _xpath; }
        }
    }
}