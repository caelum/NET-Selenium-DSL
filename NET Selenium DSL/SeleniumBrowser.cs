using Caelum.SelenuimDSL;
using System;
using Selenium;

namespace Caelum.SeleniumDSL
{
    public class SeleniumBrowser : IBrowser<ISelenium>
    {
        private ISelenium selenium;
        private long timeout;

        public SeleniumBrowser(ISelenium Selenium)
        {
            this.selenium = Selenium;
            this.timeout = 10000;
        }

        public SeleniumBrowser(ISelenium Selenium, long Timeout)
        {
            this.selenium = Selenium;
            this.timeout = Timeout;
        }

        public IPage Open(string url)
        {
            selenium.Open(url);
            selenium.WaitForPageToLoad(timeout.ToString());
            return CurrentPage();
        }

        public IPage CurrentPage()
        {
            return new Page(selenium, timeout);
        }

        public IPage WaitForPageLoad(long timeout)
        {
            selenium.WaitForPageToLoad(timeout.ToString());
            return CurrentPage();
        }

        public ISelenium GetDelegate()
        {
            return selenium;
        }

        public IPage Window(string id)
        {
            throw new NotImplementedException();
        }

    }
}
