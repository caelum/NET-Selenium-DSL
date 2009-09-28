using System;
using Selenium;

namespace Caelum.SeleniumDSL
{
    public class SeleniumBrowser : IBrowser<ISelenium>
    {
        private ISelenium selenium;
        private long timeout;

        public SeleniumBrowser(ISelenium selenium)
        {
            this.selenium = selenium;
            this.timeout = 10000;
        }

        public SeleniumBrowser(ISelenium selenium, long timeout)
        {
            this.selenium = selenium;
            this.timeout = timeout;
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
