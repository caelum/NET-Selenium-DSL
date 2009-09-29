using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public class ContentTagTest : IntegrationTest
    {
        [TestMethod]
        public void TestExists()
        {
            openIndex();
            Assert.IsTrue(browser.CurrentPage().Div("oneDiv").Exists());
        }

        [TestMethod]
        public void TestInnerHTML()
        {
            openIndex();
            Assert.AreEqual("Div content", browser.CurrentPage().Div("oneDiv").InnerHTML());
        }

        [TestMethod]
        public void TestContains()
        {
            openIndex();
            Assert.IsTrue(browser.CurrentPage().Div("oneDiv").Contains("content"));
        }
    }
}