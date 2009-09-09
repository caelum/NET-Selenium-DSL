using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;
using Caelum.SeleniumDSL;

namespace Integration.Caelum.SeleniumDSL
{
    [TestClass]
    public class IntegrationTest
    {
        protected HttpServer.HttpServer server;

        protected ISelenium selenium;

        protected IBrowser<ISelenium> browser;

        [TestInitialize]
        public void SetUp()
        {
            server = new HttpServer.HttpServer();
            server.Add(new FileReaderModule());
            server.Start(IPAddress.Any, 9100);

            selenium = new DefaultSelenium("localhost", 4444, "*firefox", "http://localhost:9100");
            selenium.Start();
            selenium.SetContext("NET Selenium DSL Tests");

            browser = new SeleniumBrowser(selenium);
        }

        [TestCleanup]
        public void TearDown()
        {
            selenium.Stop();
            server.Stop();
        }

        public void openIndex()
        {
            selenium.Open("/index.htm");
        }
    }
}
