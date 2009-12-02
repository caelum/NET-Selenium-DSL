using Caelum.SeleniumDSL.Default.Selector;
using Caelum.SeleniumDSL.Default.Tests.Integration.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    [TestClass]
    public class FormTest : IntegrationTest
    {
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
