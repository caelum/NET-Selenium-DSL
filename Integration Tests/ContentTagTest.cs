using System;
using HttpServer;
using HttpServer.HttpModules;
using HttpServer.Sessions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net;
using Caelum.SeleniumDSL;
using Selenium;

namespace Integration.Caelum.SeleniumDSL
{
    [TestClass]
    public class ContentTagTest : IntegrationTest
    {
        [TestMethod]
        public void TestExists()
        {
            IBrowser<ISelenium> browser = new SeleniumBrowser(selenium);
            browser.Open("/index.htm");

            Assert.IsTrue(browser.CurrentPage().Div("oneDiv").Exists());
        }
    }
}
