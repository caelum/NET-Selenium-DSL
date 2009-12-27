using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class FieldTest : UnitTest
    {
        private IForm _form;
        private const string FormXpath = "//form[@id='f']";

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();

            var formMock = Mockery.Create<IForm>();
            
            formMock.Setup(
                f => f.Xpath).Returns(FormXpath);

            _form = formMock.Object;
        }

        [TestMethod]
        public void TestBlur()
        {
            Selenium.Setup(
                o => o.FireEvent(FormXpath + "/input[@name='input']", "blur"));

            new Field(Selenium.Object, _form, "input").Blur();
        }

        [TestMethod]
        public void TestChange()
        {
            Selenium.Setup(
                o => o.FireEvent(FormXpath + "/input[@name='input']", "change"));

            new Field(Selenium.Object, _form, "input").Change();
        }

        [TestMethod]
        public void TestContains()
        {
            Selenium.Setup(
                o => o.GetValue(FormXpath + "/input[@name='input']"))
                .Returns("Some text");

            var field = new Field(Selenium.Object, _form, "input");

            Assert.IsTrue(field.Contains("text"));
        }

        [TestMethod]
        public void TestContent()
        {
            Selenium.Setup(o => o.GetValue(FormXpath + "/input[@name='input']"))
                .Returns("Some text");

            var field = new Field(Selenium.Object, _form, "input");

            Assert.AreEqual("Some text", field.Content());
        }

        [TestMethod]
        public void TestType()
       { 
            Selenium.Setup(
                o => o.Type(FormXpath + "/input[@name='input']", "Some text"));

            var field = new Field(Selenium.Object, _form, "input");
            field.Type("Some text");
        }
    }
}