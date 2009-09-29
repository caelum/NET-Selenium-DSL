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
            selenium.Setup(o => o.GetText(It.IsAny<string>()))
                .Returns("Some text");

            var tag = new ContentTag(selenium.Object, "someId");

            Assert.IsTrue(tag.Contains("text"));
        }

        [TestMethod]
        public void TestExists()
        {
            selenium.Setup(o => o.IsElementPresent("someId"))
                .Returns(true);

            var tag = new ContentTag(selenium.Object, "someId");

            Assert.IsTrue(tag.Exists());
        }

        [TestMethod]
        public void TestInnerHTML()
        {
            selenium.Setup(o => o.GetText("someId"))
                .Returns("Some text");

            var tag = new ContentTag(selenium.Object, "someId");

            Assert.AreEqual("Some text", tag.InnerHTML());
        }
    }
}