using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caelum.SelenuimDSL;
using Caelum.SeleniumDSL;

namespace Integration.Caelum.SeleniumDSL
{
    [TestClass]
    public class FullTableLayoutTest : IntegrationTest
    {
        [TestMethod]
        public void ReturnsCorrectCountOfRows()
        {
            openFullTable();

            new FullTableLayout();
            IPage page = browser.CurrentPage();
            ITable table = page.Table("oneTable");

            Assert.AreEqual(3, table.GetRowCount());
        }

        [TestMethod]
        public void ReturnsCorrectCountOfColumns()
        {
            openFullTable();

            IPage page = browser.CurrentPage();
            ITable table = page.Table("oneTable");

            Assert.AreEqual(3, table.GetColumnCount());
        }

        [TestMethod]
        public void ReturnsCorrectLocationOfColumn()
        {
            openFullTable();

            IPage page = browser.CurrentPage();
            ITable table = page.Table("oneTable");

            Assert.AreEqual(2, table.FindColumn("Header 2"));
        }

        [TestMethod]
        public void ReturnsCorrectCountOfItems()
        {
            openFullTable();

            IPage page = browser.CurrentPage();
            ITable table = page.Table("oneTable");

            Assert.AreEqual(2, table.GetContentCount());
        }

        [TestMethod]
        public void ReturnCorrectValuesOfCell()
        {
            openFullTable();

            IPage page = browser.CurrentPage();
            ITable table = page.Table("oneTable");

            Assert.AreEqual("Row 1 - Cell 1", table.Cell(1, 1));
            Assert.AreEqual("Row 2 - Cell 2", table.Cell(2, "Header 2"));
        }

        [TestMethod]
        public void ReturnCorrectRowNumberFromColumnSearch()
        {
            openFullTable();

            IPage page = browser.CurrentPage();
            ITable table = page.Table("oneTable");

            Assert.AreEqual(2, table.Column("Header 1").Find("Row 2 - Cell 1"));
        }

    }
}
