using System;
using System.Net;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Integration.Helpers
{
    public static class ServersHelper
    {
        private static bool _running = false;

        private static HttpServer.HttpServer _server;
        private static ISelenium _selenium;

        public static void StartServers()
        {
            if (_running)
                return;

            _server = new HttpServer.HttpServer();
            _server.Add(new FileReaderModule());
            _server.Start(IPAddress.Any, 9100);

            _selenium = new DefaultSelenium("localhost", 4444, "*firefox", "http://localhost:9100");
            _selenium.Start();
            _selenium.SetContext("NET Selenium DSL Tests");

            _running = true;
        }

        public static void StopServers()
        {
            if (!_running)
                return;

            _selenium.Stop();
            _server.Stop();

            _running = false;
        }

        public static ISelenium GetSelenium()
        {
            if (!_running)
                throw new InvalidOperationException("Servers not running.");

            return _selenium;
        }
    }
}
