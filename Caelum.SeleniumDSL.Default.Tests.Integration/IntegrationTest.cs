using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public abstract class IntegrationTest
    {
        private HttpServer.HttpServer _server;

        private ISelenium _selenium;

        protected IBrowser<ISelenium> Browser;

        [TestInitialize]
        public virtual void Setup()
        {
            _server = new HttpServer.HttpServer();
            _server.Add(new FileReaderModule());
            _server.Start(IPAddress.Any, 9100);

            _selenium = new DefaultSelenium("localhost", 4444, "*firefox", "http://localhost:9100");
            _selenium.Start();
            _selenium.SetContext("NET Selenium DSL Tests");

            Browser = new SeleniumBrowser(_selenium);
        }

        [TestCleanup]
        public void TearDown()
        {
            _selenium.Stop();
            _server.Stop();
        }

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