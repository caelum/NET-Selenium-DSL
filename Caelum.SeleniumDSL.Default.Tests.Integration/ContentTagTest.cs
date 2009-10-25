using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public class ContentTagTest : IntegrationTest
    {
        [TestMethod]
        public void TestExists()
        {
            OpenIndex();
            Assert.IsTrue(Browser.CurrentPage().Div("oneDiv").Exists());
        }

        [TestMethod]
        public void TestInnerHtml()
        {
            OpenIndex();
            Assert.AreEqual("Div content", Browser.CurrentPage().Div("oneDiv").InnerHtml());
        }

        [TestMethod]
        public void TestContains()
        {
            OpenIndex();
            Assert.IsTrue(Browser.CurrentPage().Div("oneDiv").Contains("content"));
        }
    }
}