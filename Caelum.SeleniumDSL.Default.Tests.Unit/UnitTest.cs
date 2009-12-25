using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    public class UnitTest
    {
        protected MockFactory Mockery;
        protected Mock<ISelenium> Selenium;

        [TestInitialize]
        public virtual void Setup()
        {
            Mockery = new MockFactory(MockBehavior.Default);
            Selenium = Mockery.Create<ISelenium>();
        }

        [TestCleanup]
        public void TearDown()
        {
            Mockery.VerifyAll();
        }
    }
}