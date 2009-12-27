using Caelum.SeleniumDSL.Default.Selector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class SelectFieldTest : UnitTest
    {
        private IForm _form;
        private const string FormXpath = "//form[@id='f']";

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();

            Mock<IForm> form = Mockery.Create<IForm>();
            form.Setup(
                f => f.Xpath).Returns(FormXpath);
            _form = form.Object;
        }

        [TestMethod]
        public void TestBlur()
        {
            Selenium.Setup(
                o => o.FireEvent(FormXpath + "/select[@id='select']", "blur"));

            var select = new SelectField(Selenium.Object, _form, Id.Is("select"));

            select.Blur();
        }

        [TestMethod]
        public void TestChooseWithExpectedValue()
        {
            Selenium.Setup(
                o => o.Select(FormXpath + "/select[@id='select']", "Element"));

            var select = new SelectField(Selenium.Object, _form, Id.Is("select"));

            select.Choose("Element");
        }

        [TestMethod]
        public void TestChooseWithExpectedIndexValue()
        {
            Selenium.Setup(
                o => o.Select(FormXpath + "/select[@id='select']", "Element"));
            
            Selenium.Setup(
                o => o.GetSelectOptions(FormXpath + "/select[@id='select']"))
                .Returns(new[] {"", "", "Element"});

            var select = new SelectField(Selenium.Object, _form, Id.Is("select"));

            select.Choose(2);
        }

        [TestMethod]
        public void Content()
        {
            Selenium.Setup(
                o => o.GetSelectedLabel(FormXpath + "/select[@id='select']"));

            var select = new SelectField(Selenium.Object, _form, Id.Is("select"));

            select.Content();
        }

        [TestMethod]
        public void Value()
        {
            Selenium.Setup(
                o => o.GetValue(FormXpath + "/select[@id='select']"));

            var select = new SelectField(Selenium.Object, _form, Id.Is("select"));

            select.Value();
        }

        [TestMethod]
        public void Values()
        {
            Selenium.Setup(
                o => o.GetSelectOptions(FormXpath + "/select[@id='select']"));

            var select = new SelectField(Selenium.Object, _form, Id.Is("select"));

            select.Values();
        }
    }
}