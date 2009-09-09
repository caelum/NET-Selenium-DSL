using Caelum.SeleniumDSL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;
using Moq;

namespace Caelum.SeleniumDSL
{
    [TestClass]
    public class ContentTagTest
    {
        private MockFactory factory;
        private Mock<ISelenium> mock;

        [TestInitialize]
        public void SetUp()
        {
            factory = new MockFactory(MockBehavior.Default);
            mock = factory.Create<ISelenium>();
        }

        [TestCleanup]
        public void TearDown()
        {
            mock.VerifyAll();
        }

        [TestMethod]
        public void TestContains()
        {
            mock.Setup(o => o.GetText(It.IsAny<string>())).Returns("");

            SeleniumBrowser browser = new SeleniumBrowser(mock.Object);
            browser.CurrentPage().Div("id").Contains("");
        }

        [TestMethod]
        public void TestExists()
        {
            mock.Setup(o => o.IsElementPresent(It.IsAny<string>())).Returns(true);

            SeleniumBrowser browser = new SeleniumBrowser(mock.Object);
            browser.CurrentPage().Div("id").Exists();
        }

        [TestMethod]
        public void TestInnerHTML()
        {
            mock.Setup(o => o.GetText(It.IsAny<string>())).Returns("");

            SeleniumBrowser browser = new SeleniumBrowser(mock.Object);
            browser.CurrentPage().Div("id").InnerHTML();
        }

    }
}
