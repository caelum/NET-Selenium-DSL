using Caelum.SeleniumDSL.Default.Table.Layout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration.Table.Layout
{
    [TestClass]
    public class PlainTableLayoutTest : IntegrationTest
    {
        private PlainTableLayout tableLayout;

        [TestInitialize]
        public override void SetUp()
        {
            base.SetUp();
            openPlainTable();
            tableLayout = new PlainTableLayout(selenium, "oneTable");
        }

        [TestMethod]
        public void ReturnsCorrectCountOfRows()
        {
            Assert.AreEqual(3, tableLayout.GetRowCount());
        }

        [TestMethod]
        public void ReturnsCorrectCountOfColumns()
        {
            Assert.AreEqual(3, tableLayout.GetColumnCount());
        }

        //[TestMethod]
        //public void ReturnsCorrectLocationOfColumn()
        //{
        //    Assert.AreEqual(2, table.FindColumn("Header 2"));
        //}

        [TestMethod]
        public void ReturnsCorrectCountOfContents()
        {
            Assert.AreEqual(2, tableLayout.GetContentCount());
        }

        [TestMethod]
        public void ReturnsLinkFromHeader()
        {
            Assert.AreEqual("Header 3", tableLayout.HeaderLinkValue(3));
        }

        [TestMethod]
        public void ReturnsContentFromHeader()
        {
            Assert.AreEqual("Header 2", tableLayout.HeaderValue(2));
        }

        //[TestMethod]
        //public void ReturnCorrectValuesOfCell()
        //{
        //    IPage page = browser.CurrentPage();
        //    ITable table = page.Table("oneTable");

        //    Assert.AreEqual("Row 1 - Cell 1", table.Cell(1, 1));
        //    Assert.AreEqual("Row 2 - Cell 2", table.Cell(2, "Header 2"));
        //}

        //[TestMethod]
        //public void ReturnCorrectRowNumberFromColumnSearch()
        //{
        //    IPage page = browser.CurrentPage();
        //    ITable table = page.Table("oneTable");

        //    Assert.AreEqual(2, table.Column("Header 1").Find("Row 2 - Cell 1"));
        //}

        [TestMethod]
        public void ReturnCorrectValueOfCellAtGivenRow()
        {
            Assert.AreEqual("Row 1 - Cell 2", tableLayout.Value(1, 2));
        }

    }

}