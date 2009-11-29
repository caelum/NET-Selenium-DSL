using Caelum.SeleniumDSL.Default.Table.Layout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration.Table.Layout
{
    [TestClass]
    public class TableLayoutChooserTest : IntegrationTest
    {
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
