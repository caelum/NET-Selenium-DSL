using Caelum.SeleniumDSL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;
using Moq;
using Unit.Caelum.SeleniumDSL;

namespace Unit.Caelum.SeleniumDSL
{
    [TestClass]
    public class ContentTagTest : UnitTest
    {
        
        [TestMethod]
        public void TestContains()
        {
            selenium.Setup(o => o.GetText(It.IsAny<string>()))
                .Returns("Some text");

            ContentTag tag = new ContentTag(selenium.Object, "someId");
            
            Assert.IsTrue(tag.Contains("text"));
        }

        [TestMethod]
        public void TestExists()
        {
            selenium.Setup(o => o.IsElementPresent("someId"))
                .Returns(true);

            ContentTag tag = new ContentTag(selenium.Object, "someId");

            Assert.IsTrue(tag.Exists());
        }

        [TestMethod]
        public void TestInnerHTML()
        {
            selenium.Setup(o => o.GetText("someId"))
                .Returns("Some text");

            ContentTag tag = new ContentTag(selenium.Object, "someId");

            Assert.AreEqual("Some text", tag.InnerHTML());
        }

    }
}
