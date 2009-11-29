using Caelum.SeleniumDSL.Default.Selector;
using Caelum.SeleniumDSL.Selector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class ContentTagTest : UnitTest
    {
        private IContentTag _tag;
        private string _expression;

        [TestInitialize]
        public new void Setup()
        {
            base.Setup();
            ISelector selector = Id.Is("someId");
            _tag = new ContentTag(Selenium.Object, selector);
            _expression = selector.GetExpression();
        }

        [TestMethod]
        public void TestContains()
        {
            Selenium.Setup(o => o.GetText("//*" + _expression))
                .Returns("Some text");

            Assert.IsTrue(_tag.Contains("text"));
        }

        [TestMethod]
        public void TestExists()
        {
            Selenium.Setup(o => o.IsElementPresent("//*" + _expression))
                .Returns(true);

            Assert.IsTrue(_tag.Exists());
        }

        [TestMethod]
        public void TestInnerHtml()
        {
            Selenium.Setup(o => o.GetText("//*" + _expression))
                .Returns("Some text");

            Assert.AreEqual("Some text", _tag.InnerHtml());
        }
    }
}