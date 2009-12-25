using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public abstract class IntegrationTest
    {
        protected static IBrowser<ISelenium> Browser;

        protected void OpenFullTable()
        {
            Browser.Open("/table/fulltable.html");
        }

        protected void OpenPlainTable()
        {
            Browser.Open("/table/plaintable.html");
        }

        protected void OpenPlainTablePlusTh()
        {
            Browser.Open("/table/plaintableplusth.html");
        }

        protected void OpenForm()
        {
            Browser.Open("/form/form.html");
        }
    }
}