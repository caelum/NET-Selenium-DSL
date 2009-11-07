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
            var chooser = new TableLayoutChooser(Selenium, "oneTable");
            ITableLayout layout = chooser.GetLayout();

            Assert.IsInstanceOfType(layout, typeof(PlainTableLayout));
        }

        [TestMethod]
        public void ShouldChoosePlainTablePlusThLayoutWhenHasThsButDoesNotHaveThead()
        {
            OpenPlainTablePlusTh();
            var chooser = new TableLayoutChooser(Selenium, "oneTable");
            ITableLayout layout = chooser.GetLayout();

            Assert.IsInstanceOfType(layout, typeof(PlainTablePlusThLayout));
        }

        [TestMethod]
        public void ShouldChooseFullTableLayoutWhenHasTheadAndThs()
        {
            OpenFullTable();
            var chooser = new TableLayoutChooser(Selenium, "oneTable");
            ITableLayout layout = chooser.GetLayout();

            Assert.IsInstanceOfType(layout, typeof(FullTableLayout));
        }
    }
}
