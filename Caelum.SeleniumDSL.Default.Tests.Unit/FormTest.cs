using Caelum.SeleniumDSL.Default.Selector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class FormTest : UnitTest
    {
        private IForm _form;

        [TestInitialize]
        public new void Setup()
        {
            base.Setup();
            _form = new Form(Selenium.Object, 10000, Id.Is("form"));
        }

        [TestMethod]
        public void TestCheck()
        {
            Selenium.Setup(o => o.Check("oneCheckbox"));

            _form.Check("oneCheckbox");
        }

        [TestMethod]
        public void TestClick()
        {
            Selenium.Setup(o => o.Click("someElement"));

            _form.Click("someElement");
        }

        [TestMethod]
        public void TestIsChecked()
        {
            Selenium.Setup(o => o.IsChecked("someElement"))
                .Returns(true);


            Assert.IsTrue(_form.IsChecked("someElement"));
        }

        [TestMethod]
        public void TestNavigate()
        {
            Selenium.Setup(o => o.Click("someElement"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            _form.Navigate("someElement");
        }

        [TestMethod]
        public void TestSubmit()
        {
            Selenium.Setup(o => o.Submit("//form[@id='form']"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            _form.Submit();
        }

        [TestMethod]
        public void TestUncheck()
        {
            Selenium.Setup(o => o.Uncheck("someElement"));

            _form.Uncheck("someElement");
        }
    }
}