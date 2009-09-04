using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Selenium;

namespace Caelum.SeleniumDSL
{
    public class ContentTag : IContentTag
    {

        private ISelenium selenium;
        private string id;

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
