using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class FieldTest : UnitTest
    {
        [TestMethod]
        public void TestBlur()
        {
            Selenium.Setup(o => o.FireEvent("", "blur"));

            new Field(Selenium.Object, null, "").Blur();
        }

        [TestMethod]
        public void TestChange()
        {
            Selenium.Setup(o => o.FireEvent("", "change"));

            new Field(Selenium.Object, null, "").Change();
        }

        [TestMethod]
        public void TestContains()
        {
            Selenium.Setup(o => o.GetValue("someId"))
                .Returns("Some text");

            var field = new Field(Selenium.Object, null, "someId");

            Assert.IsTrue(field.Contains("text"));
        }

        [TestMethod]
        public void TestContent()
        {
            Selenium.Setup(o => o.GetValue("someId"))
                .Returns("Some text");

            var field = new Field(Selenium.Object, null, "someId");

            Assert.AreEqual("Some text", field.Content());
        }

        [TestMethod]
        public void TestType()
        {
            Selenium.Setup(o => o.Type("someId", "Some text"));

            var field = new Field(Selenium.Object, null, "someId");

            field.Type("Some text");
        }
    }
}