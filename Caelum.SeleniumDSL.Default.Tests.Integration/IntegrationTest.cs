using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public abstract class IntegrationTest
    {
        private HttpServer.HttpServer _server;

        protected ISelenium Selenium;

        protected IBrowser<ISelenium> Browser;

        [TestInitialize]
        public virtual void SetUp()
        {
            _server = new HttpServer.HttpServer();
            _server.Add(new FileReaderModule());
            _server.Start(IPAddress.Any, 9100);

            Selenium = new DefaultSelenium("localhost", 4444, "*firefox", "http://localhost:9100");
            Selenium.Start();
            Selenium.SetContext("NET Selenium DSL Tests");

            Browser = new SeleniumBrowser(Selenium);
        }

        [TestCleanup]
        public void TearDown()
        {
            Selenium.Stop();
            _server.Stop();
        }

        public void OpenIndex()
        {
            Browser.Open("/index.html");
        }

        public void OpenEvents()
        {
            Browser.Open("/events.html");
        }

        public void OpenFullTable()
        {
            Browser.Open("/fulltable.html");
        }

        public void OpenPlainTable()
        {
            Browser.Open("/plaintable.html");
        }

        public void OpenPlainTablePlusTh()
        {
            Browser.Open("plaintableplusth.html");
        }
    }
}