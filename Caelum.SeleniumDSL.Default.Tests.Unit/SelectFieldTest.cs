using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class SelectFieldTest : UnitTest
    {
        [TestMethod]
        public void TestBlur()
        {
            selenium.Setup(o => o.FireEvent("selectId", "blur"));

            var select = new SelectField(selenium.Object, null, "selectId");

            select.Blur();
        }

        [TestMethod]
        public void TestChooseWithExpectedValue()
        {
            selenium.Setup(o => o.Select("selectId", "Element"));

            var select = new SelectField(selenium.Object, null, "selectId");

            select.Choose("Element");
        }

        [TestMethod]
        public void TestChooseWithExpectedIndexValue()
        {
            selenium.Setup(o => o.Select("selectId", "Element"));
            selenium.Setup(o => o.GetSelectOptions("selectId"))
                .Returns(new[] {"", "", "Element"});

            var select = new SelectField(selenium.Object, null, "selectId");

            select.Choose(2);
        }

        [TestMethod]
        public void Content()
        {
            selenium.Setup(o => o.GetSelectedLabel("selectId"));

            var select = new SelectField(selenium.Object, null, "selectId");

            select.Content();
        }

        [TestMethod]
        public void Value()
        {
            selenium.Setup(o => o.GetValue("selectId"));

            var select = new SelectField(selenium.Object, null, "selectId");

            select.Value();
        }

        [TestMethod]
        public void Values()
        {
            selenium.Setup(o => o.GetSelectOptions("selectId"));

            var select = new SelectField(selenium.Object, null, "selectId");

            select.Values();
        }
    }
}