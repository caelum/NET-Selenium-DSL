using Caelum.SeleniumDSL.Default.Table.Layout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit.Table.Layout
{
    [TestClass]
    public class TableLayoutChooserTest : UnitTest
    {
        [TestMethod]
        public void ShouldChoosePlainTableLayoutWhenDoesNotHaveTheadAndThs()
        {
            Selenium.Setup(o => o.GetXpathCount("id('tableId')/thead")).Returns(0);
            Selenium.Setup(o => o.GetXpathCount("id('tableId')//th")).Returns(0);

            var chooser = new TableLayoutChooser(Selenium.Object, "tableId");
            ITableLayout layout = chooser.GetLayout();

            Assert.IsInstanceOfType(layout, typeof(PlainTableLayout));
        }

        [TestMethod]
        public void ShouldChoosePlainTablePlusThLayoutWhenHasThsButDoesNotHaveThead()
        {
            Selenium.Setup(o => o.GetXpathCount("id('tableId')/thead")).Returns(0);
            Selenium.Setup(o => o.GetXpathCount("id('tableId')//th")).Returns(1);

            var chooser = new TableLayoutChooser(Selenium.Object, "tableId");
            ITableLayout layout = chooser.GetLayout();

            Assert.IsInstanceOfType(layout, typeof(PlainTablePlusThLayout));
        }

        [TestMethod]
        public void ShouldChooseFullTableLayoutWhenHasTheadAndThs()
        {
            Selenium.Setup(o => o.GetXpathCount("id('tableId')/thead")).Returns(1);
            Selenium.Setup(o => o.GetXpathCount("id('tableId')//th")).Returns(1);

            var chooser = new TableLayoutChooser(Selenium.Object, "tableId");
            ITableLayout layout = chooser.GetLayout();

            Assert.IsInstanceOfType(layout, typeof(FullTableLayout));
        }
    }
}
