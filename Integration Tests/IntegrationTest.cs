using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;

namespace Integration.Caelum.SeleniumDSL
{
    [TestClass]
    public class IntegrationTest
    {
        protected HttpServer.HttpServer server;

        protected ISelenium selenium;

        [TestInitialize]
        public void SetUp()
        {
            server = new HttpServer.HttpServer();
            server.Add(new FileReaderModule());
            server.Start(IPAddress.Any, 9100);

            selenium = new DefaultSelenium("localhost", 4444, "*firefox", "http://localhost:9100");
            selenium.Start();
            selenium.SetContext("NET Selenium DSL Tests");
        }

        [TestCleanup]
        public void TearDown()
        {
            server.Stop();
            selenium.Stop();
        }

        public void openIndex()
        {
            selenium.Open("/index.htm");
        }
    }
}
