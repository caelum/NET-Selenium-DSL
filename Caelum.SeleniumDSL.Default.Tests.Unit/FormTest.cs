using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit.Caelum.SeleniumDSL;
using Caelum.SeleniumDSL;

namespace Unit.Caelum.SeleniumDSL
{
    [TestClass]
    public class FormTest : UnitTest
    {
        [TestMethod]
        public void TestCheck()
        {
            selenium.Setup(o => o.Check("oneCheckbox"));

            Form form = new Form(selenium.Object, 10000, "form");
            form.Check("oneCheckbox");
        }

        [TestMethod]
        public void TestClick()
        {
            selenium.Setup(o => o.Click("someElement"));

            Form form = new Form(selenium.Object, 10000, "form");
            form.Click("someElement");
        }

        [TestMethod]
        public void TestIsChecked()
        {
            selenium.Setup(o => o.IsChecked("someElement"))
                .Returns(true);

            Form form = new Form(selenium.Object, 10000, "form");
            
            Assert.IsTrue(form.IsChecked("someElement"));
        }

        [TestMethod]
        public void TestNavigate()
        {
            selenium.Setup(o => o.Click("someElement"));
            selenium.Setup(o => o.WaitForPageToLoad("10000"));

            Form form = new Form(selenium.Object, 10000, "form");
            form.Navigate("someElement");
        }

        [TestMethod]
        public void TestSubmit()
        {
            selenium.Setup(o => o.Submit("form"));
            selenium.Setup(o => o.WaitForPageToLoad("10000"));

            Form form = new Form(selenium.Object, 10000, "form");
            form.Submit();
        }

        [TestMethod]
        public void TestUncheck()
        {
            selenium.Setup(o => o.Uncheck("someElement"));

            Form form = new Form(selenium.Object, 10000, "form");
            form.Uncheck("someElement");
        }
        
    }
}
