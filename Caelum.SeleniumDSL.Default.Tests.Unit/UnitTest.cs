using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    public class UnitTest
    {
        protected MockFactory MockFactory;
        protected Mock<ISelenium> Selenium;

        [TestInitialize]
        public void SetUp()
        {
            MockFactory = new MockFactory(MockBehavior.Default);
            Selenium = MockFactory.Create<ISelenium>();
        }

        [TestCleanup]
        public void TearDown()
        {
            Console.WriteLine("Verificando mocks");
            MockFactory.VerifyAll();
        }
    }
}