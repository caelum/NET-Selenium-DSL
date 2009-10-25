using System;
using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    public sealed class SeleniumBrowser : IBrowser<ISelenium>
    {
        private readonly ISelenium _selenium;
        private readonly long _timeout;

        public SeleniumBrowser(ISelenium selenium)
        {
            _selenium = selenium;
            _timeout = 10000;
        }

        public SeleniumBrowser(ISelenium selenium, long timeout)
        {
            _selenium = selenium;
            _timeout = timeout;
        }

        public IPage Open(string url)
        {
            _selenium.Open(url);
            _selenium.WaitForPageToLoad(_timeout.ToString());
            return CurrentPage();
        }

        public IPage CurrentPage()
        {
            return new Page(_selenium, _timeout);
        }

        public IPage WaitForPageLoad(long timeout)
        {
            _selenium.WaitForPageToLoad(timeout.ToString());
            return CurrentPage();
        }

        public ISelenium GetDelegate()
        {
            return _selenium;
        }

        public IPage Window(string id)
        {
            throw new NotImplementedException();
        }
    }
}