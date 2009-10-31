using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    public class UnitTest
    {
        protected MockFactory Factory;
        protected Mock<ISelenium> Selenium;

        [TestInitialize]
        public void SetUp()
        {
            Factory = new MockFactory(MockBehavior.Default);
            Selenium = Factory.Create<ISelenium>();
        }

        [TestCleanup]
        public void TearDown()
        {
            Factory.VerifyAll();
        }
    }
}