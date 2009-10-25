using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public class FieldTest : IntegrationTest
    {
        [TestMethod]
        public void TestBlur()
        {
            OpenEvents();
            IPage page = Browser.CurrentPage();

            page.Form("oneForm").Field("blurInput").Blur();

            Assert.IsTrue(page.Div("oneDiv").Contains("blur"));
        }

        [TestMethod]
        public void TestChange()
        {
            OpenEvents();
            IPage page = Browser.CurrentPage();

            page.Form("oneForm").Field("changeInput").Change();

            Assert.IsTrue(page.Div("oneDiv").Contains("change"));
        }

        [TestMethod]
        public void TestThatTypeValueInsideField()
        {
            OpenEvents();
            IField field = Browser.CurrentPage().Form("oneForm").Field("changeInput");

            field.Type("Some text");

            Assert.IsTrue(field.Contains("text"));
            Assert.AreEqual("Some text", field.Content());
        }
    }
}