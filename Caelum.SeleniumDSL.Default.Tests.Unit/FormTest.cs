using Caelum.SeleniumDSL.Default.Selector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class FormTest : UnitTest
    {
        private IForm _form;

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();
            _form = new Form(Selenium.Object, 10000, Id.Is("f"));
        }

        [TestMethod]
        public void TestCheck()
        {
            Selenium.Setup(o => o.Check("//form[@id='f']/input[@name='oneCheckbox']"));

            _form.Check("oneCheckbox");
        }

        [TestMethod]
        public void TestClick()
        {
            Selenium.Setup(o => o.Click("//form[@id='f']/*[@name='someElement']"));

            _form.Click("someElement");
        }

        [TestMethod]
        public void TestIsChecked()
        {
            Selenium.Setup(o => o.IsChecked("//form[@id='f']/input[@name='someElement']"))
                .Returns(true);


            Assert.IsTrue(_form.IsChecked("someElement"));
        }

        [TestMethod]
        public void TestNavigate()
        {
            Selenium.Setup(o => o.Click("//form[@id='f']/*[@name='someElement']"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            _form.Navigate("someElement");
        }

        [TestMethod]
        public void TestSubmit()
        {
            Selenium.Setup(o => o.Submit("//form[@id='f']"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            _form.Submit();
        }

        [TestMethod]
        public void TestUncheck()
        {
            Selenium.Setup(o => o.Uncheck("//form[@id='f']/input[@name='someElement']"));

            _form.Uncheck("someElement");
        }
    }
}