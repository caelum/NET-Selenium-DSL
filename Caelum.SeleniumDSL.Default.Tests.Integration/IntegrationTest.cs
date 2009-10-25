﻿using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public abstract class IntegrationTest
    {
        protected HttpServer.HttpServer server;

        protected ISelenium selenium;

        protected IBrowser<ISelenium> browser;

        [TestInitialize]
        public virtual void SetUp()
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
            browser.Open("/index.html");
        }

        public void openEvents()
        {
            browser.Open("/events.html");
        }

        public void openFullTable()
        {
            browser.Open("/fulltable.html");
        }

        public void openPlainTable()
        {
            browser.Open("/plaintable.html");
        }

        public void openPlainTablePlusTh()
        {
            browser.Open("plaintableplusth.html");
        }
    }
}