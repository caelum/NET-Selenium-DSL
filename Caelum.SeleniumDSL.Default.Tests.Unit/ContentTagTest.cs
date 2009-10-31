using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class ContentTagTest : UnitTest
    {
        [TestMethod]
        public void TestContains()
        {
            Selenium.Setup(o => o.GetText(It.IsAny<string>()))
                .Returns("Some text");

            var tag = new ContentTag(Selenium.Object, "someId");

            Assert.IsTrue(tag.Contains("text"));
        }

        [TestMethod]
        public void TestExists()
        {
            Selenium.Setup(o => o.IsElementPresent("someId"))
                .Returns(true);

            var tag = new ContentTag(Selenium.Object, "someId");

            Assert.IsTrue(tag.Exists());
        }

        [TestMethod]
        public void TestInnerHtml()
        {
            Selenium.Setup(o => o.GetText("someId"))
                .Returns("Some text");

            var tag = new ContentTag(Selenium.Object, "someId");

            Assert.AreEqual("Some text", tag.InnerHtml());
        }
    }
}