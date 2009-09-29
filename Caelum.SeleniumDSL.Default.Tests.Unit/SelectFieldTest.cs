using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caelum.SeleniumDSL;

namespace Unit.Caelum.SeleniumDSL
{
    [TestClass]
    public class SelectFieldTest : UnitTest
    {

        [TestMethod]
        public void TestBlur()
        {
            selenium.Setup(o => o.FireEvent("selectId", "blur"));

            SelectField select = new SelectField(selenium.Object, null, "selectId");

            select.Blur();
        }

        [TestMethod]
        public void TestChooseWithExpectedValue()
        {
            selenium.Setup(o => o.Select("selectId", "Element"));

            SelectField select = new SelectField(selenium.Object, null, "selectId");

            select.Choose("Element");
        }

        [TestMethod]
        public void TestChooseWithExpectedIndexValue()
        {
            selenium.Setup(o => o.Select("selectId", "Element"));
            selenium.Setup(o => o.GetSelectOptions("selectId"))
                .Returns(new string[] { "", "", "Element" }); 

            SelectField select = new SelectField(selenium.Object, null, "selectId");

            select.Choose(2);
        }

        [TestMethod]
        public void Content()
        {
            selenium.Setup(o => o.GetSelectedLabel("selectId"));

            SelectField select = new SelectField(selenium.Object, null, "selectId");

            select.Content();
        }

        [TestMethod]
        public void Value()
        {
            selenium.Setup(o => o.GetValue("selectId"));

            SelectField select = new SelectField(selenium.Object, null, "selectId");

            select.Value();
        }

        [TestMethod]
        public void Values()
        {
            selenium.Setup(o => o.GetSelectOptions("selectId"));

            SelectField select = new SelectField(selenium.Object, null, "selectId");

            select.Values();
        }


    }
}
