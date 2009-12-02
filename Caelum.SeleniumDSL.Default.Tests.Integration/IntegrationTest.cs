using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public abstract class IntegrationTest
    {
        protected static IBrowser<ISelenium> Browser;

        public void OpenFullTable()
        {
            Browser.Open("/table/fulltable.html");
        }

        public void OpenPlainTable()
        {
            Browser.Open("/table/plaintable.html");
        }

        public void OpenPlainTablePlusTh()
        {
            Browser.Open("/table/plaintableplusth.html");
        }

        public void OpenForm()
        {
            Browser.Open("/form/form.html");
        }
    }
}