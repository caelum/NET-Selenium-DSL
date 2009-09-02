using Caelum.SelenuimDSL;
using System;
using Selenium;

namespace Caelum.SeleniumDSL
{
    public class SeleniumBrowser : IBrowser
    {
        private ISelenium selenium;

        public SeleniumBrowser(ISelenium selenium)
        {
            this.selenium = selenium;
        }

        public IPage Open(string url)
        {
            throw new NotImplementedException();
        }

        public IPage CurrentPage()
        {
            throw new NotImplementedException();
        }

        public IPage WaitForPageLoad(long timeout)
        {
            throw new NotImplementedException();
        }

        public object GetDelegate()
        {
            throw new NotImplementedException();
        }

        public IPage Window(string id)
        {
            throw new NotImplementedException();
        }

    }
}
