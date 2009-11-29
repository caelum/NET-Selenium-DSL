using Caelum.SeleniumDSL.Default.Selector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public class FormTest : IntegrationTest
    {
        [TestMethod]
        public void CanSubmitForm()
        {
            OpenForm();

            IPage page = Browser.CurrentPage();
            page.Form(Id.Is("testform")).Submit();

            Assert.IsTrue(page.Div(Id.Is("ok")).Exists());
        }
    }
}
