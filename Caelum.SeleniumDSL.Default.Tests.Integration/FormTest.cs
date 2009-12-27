using Caelum.SeleniumDSL.Default.Selector;
using Caelum.SeleniumDSL.Default.Tests.Integration.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public class FormTest : IntegrationTest
    {

        private IForm _form;

        [ClassInitialize]
        public static void Initialize(TestContext ignore)
        {
            ServersHelper.StartServers();
            Browser = new SeleniumBrowser(ServersHelper.GetSelenium());
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            ServersHelper.StopServers();
        }

        [TestInitialize]
        public void Setup()
        {
            OpenForm();

            var page = Browser.CurrentPage();
            _form = page.Form(Id.Is("testform"));
        }

        [TestMethod]
        public void CanSubmitForm()
        {
            var page = _form.Submit();

            Assert.IsTrue(page.Div(Id.Is("ok")).Exists());
        }

        [TestMethod]
        public void CanReadAndWriteValuesOnFields()
        {
            _form.Field("field1").Type("some text");
            Assert.AreEqual("some text", _form.Field("field1").Content());

            Assert.AreEqual("text on field 2", _form.Field("field2").Content());
        }

        [TestMethod]
        public void CanCheckAndUncheckCheckboxes()
        {
            Assert.IsTrue(_form.IsChecked("check1"));
            Assert.IsFalse(_form.IsChecked("check2"));

            _form.Check("check2");
            Assert.IsTrue(_form.IsChecked("check2"));
            Assert.IsFalse(_form.IsChecked("check3"));
        }

        [TestMethod]
        public void CanReadAllValuesFromSelect()
        {
            var @select = _form.Select("select1");
            var values = @select.Values();

            Assert.AreEqual(values.Length, 4);
            Assert.AreEqual(values[0], "Option 1");
            Assert.AreEqual(values[1], "Option 2");
            Assert.AreEqual(values[2], "Option 3");
            Assert.AreEqual(values[3], "Option 4");

            Assert.AreEqual("1", @select.Value());

            @select.Choose(3);
            Assert.AreEqual("4", @select.Value());

            @select.Choose("Option 2");
            Assert.AreEqual("2", @select.Value());
        }
    }
}
