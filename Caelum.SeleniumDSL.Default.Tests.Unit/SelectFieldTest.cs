using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class SelectFieldTest : UnitTest
    {
        [TestMethod]
        public void TestBlur()
        {
            Selenium.Setup(o => o.FireEvent("selectId", "blur"));

            var select = new SelectField(Selenium.Object, null, "selectId");

            select.Blur();
        }

        [TestMethod]
        public void TestChooseWithExpectedValue()
        {
            Selenium.Setup(o => o.Select("selectId", "Element"));

            var select = new SelectField(Selenium.Object, null, "selectId");

            select.Choose("Element");
        }

        [TestMethod]
        public void TestChooseWithExpectedIndexValue()
        {
            Selenium.Setup(o => o.Select("selectId", "Element"));
            Selenium.Setup(o => o.GetSelectOptions("selectId"))
                .Returns(new[] {"", "", "Element"});

            var select = new SelectField(Selenium.Object, null, "selectId");

            select.Choose(2);
        }

        [TestMethod]
        public void Content()
        {
            Selenium.Setup(o => o.GetSelectedLabel("selectId"));

            var select = new SelectField(Selenium.Object, null, "selectId");

            select.Content();
        }

        [TestMethod]
        public void Value()
        {
            Selenium.Setup(o => o.GetValue("selectId"));

            var select = new SelectField(Selenium.Object, null, "selectId");

            select.Value();
        }

        [TestMethod]
        public void Values()
        {
            Selenium.Setup(o => o.GetSelectOptions("selectId"));

            var select = new SelectField(Selenium.Object, null, "selectId");

            select.Values();
        }
    }
}