using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
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