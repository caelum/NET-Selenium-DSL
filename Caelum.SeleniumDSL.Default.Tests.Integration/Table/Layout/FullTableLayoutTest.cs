﻿using Caelum.SeleniumDSL.Default.Table.Layout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration.Table.Layout
{
    [TestClass]
    public class FullTableLayoutTest : IntegrationTest
    {
        private FullTableLayout _tableLayout;

        [TestInitialize]
        public override void SetUp()
        {
            base.SetUp();
            OpenFullTable();
            _tableLayout = new FullTableLayout(Selenium, "oneTable");
        }

        [TestMethod]
        public void ReturnsCorrectCountOfRows()
        {
            Assert.AreEqual(3, _tableLayout.GetRowCount());
        }

        [TestMethod]
        public void ReturnsCorrectCountOfColumns()
        {
            Assert.AreEqual(3, _tableLayout.GetColumnCount());
        }

        //[TestMethod]
        //public void ReturnsCorrectLocationOfColumn()
        //{
        //    Assert.AreEqual(2, table.FindColumn("Header 2"));
        //}

        [TestMethod]
        public void ReturnsCorrectCountOfContents()
        {
            Assert.AreEqual(2, _tableLayout.GetContentCount());
        }

        [TestMethod]
        public void ReturnsLinkFromHeader()
        {
            Assert.AreEqual("Header 3", _tableLayout.HeaderLinkValue(3));
        }

        [TestMethod]
        public void ReturnsContentFromHeader()
        {
            Assert.AreEqual("Header 2", _tableLayout.HeaderValue(2));
        }

        //[TestMethod]
        //public void ReturnCorrectValuesOfCell()
        //{
        //    IPage page = Browser.CurrentPage();
        //    ITable table = page.Table("oneTable");

        //    Assert.AreEqual("Row 1 - Cell 1", table.Cell(1, 1));
        //    Assert.AreEqual("Row 2 - Cell 2", table.Cell(2, "Header 2"));
        //}

        //[TestMethod]
        //public void ReturnCorrectRowNumberFromColumnSearch()
        //{
        //    IPage page = Browser.CurrentPage();
        //    ITable table = page.Table("oneTable");

        //    Assert.AreEqual(2, table.Column("Header 1").Find("Row 2 - Cell 1"));
        //}

        [TestMethod]
        public void ReturnCorrectValueOfCellAtGivenRow()
        {
            Assert.AreEqual("Row 1 - Cell 2", _tableLayout.Value(1, 2));
        }

    }

}