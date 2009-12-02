using Caelum.SeleniumDSL.Default.Table.Layout;
using Caelum.SeleniumDSL.Default.Tests.Integration.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration.Table.Layout
{
    [TestClass]
    public class TableLayoutChooserTest : IntegrationTest
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
        public void ShouldChoosePlainTableLayoutWhenDoesNotHaveTheadAndThs()
        {
            OpenPlainTable();
            var layout = new TableLayoutChooser(Browser.GetDelegate(), "oneTable").GetLayout();
            Assert.IsInstanceOfType(layout, typeof(PlainTableLayout));
        }

        [TestMethod]
        public void ShouldChoosePlainTablePlusThLayoutWhenHasThsButDoesNotHaveThead()
        {
            OpenPlainTablePlusTh();
            var layout = new TableLayoutChooser(Browser.GetDelegate(), "oneTable").GetLayout();
            Assert.IsInstanceOfType(layout, typeof(PlainTablePlusThLayout));
        }

        [TestMethod]
        public void ShouldChooseFullTableLayoutWhenHasTheadAndThs()
        {
            OpenFullTable();
            var layout = new TableLayoutChooser(Browser.GetDelegate(), "oneTable").GetLayout();
            Assert.IsInstanceOfType(layout, typeof(FullTableLayout));
        }
    }
}
