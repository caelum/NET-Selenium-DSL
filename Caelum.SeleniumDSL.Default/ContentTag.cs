using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class ContentTag : IContentTag
    {
        private readonly ISelenium selenium;
        private readonly string id;

        public ContentTag(ISelenium Selenium, string Id)
        {
            this.selenium = Selenium;
            this.id = Id;
        }

        public bool Contains(string Content)
        {
            return selenium.GetText(id).Contains(Content);
        }

        public bool Exists()
        {
            return selenium.IsElementPresent(id);
        }

        public string InnerHTML()
        {
            return selenium.GetText(id);
        }
    }
}