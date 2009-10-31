using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class FormTest : UnitTest
    {
        [TestMethod]
        public void TestCheck()
        {
            Selenium.Setup(o => o.Check("oneCheckbox"));

            var form = new Form(Selenium.Object, 10000, "form");
            form.Check("oneCheckbox");
        }

        [TestMethod]
        public void TestClick()
        {
            Selenium.Setup(o => o.Click("someElement"));

            var form = new Form(Selenium.Object, 10000, "form");
            form.Click("someElement");
        }

        [TestMethod]
        public void TestIsChecked()
        {
            Selenium.Setup(o => o.IsChecked("someElement"))
                .Returns(true);

            var form = new Form(Selenium.Object, 10000, "form");

            Assert.IsTrue(form.IsChecked("someElement"));
        }

        [TestMethod]
        public void TestNavigate()
        {
            Selenium.Setup(o => o.Click("someElement"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            var form = new Form(Selenium.Object, 10000, "form");
            form.Navigate("someElement");
        }

        [TestMethod]
        public void TestSubmit()
        {
            Selenium.Setup(o => o.Submit("form"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            var form = new Form(Selenium.Object, 10000, "form");
            form.Submit();
        }

        [TestMethod]
        public void TestUncheck()
        {
            Selenium.Setup(o => o.Uncheck("someElement"));

            var form = new Form(Selenium.Object, 10000, "form");
            form.Uncheck("someElement");
        }
    }
}