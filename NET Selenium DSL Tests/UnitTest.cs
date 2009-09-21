using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit.Caelum.SeleniumDSL
{
    public class UnitTest
    {
        protected MockFactory factory;
        protected Mock<ISelenium> selenium;

        [TestInitialize]
        public void SetUp()
        {
            factory = new MockFactory(MockBehavior.Default);
            selenium = factory.Create<ISelenium>();
        }

        [TestCleanup]
        public void TearDown()
        {
            factory.VerifyAll();
        }
    }
}
