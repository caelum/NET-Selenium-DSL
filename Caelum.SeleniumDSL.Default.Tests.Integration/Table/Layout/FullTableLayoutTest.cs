using Caelum.SeleniumDSL.Default.Table.Layout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Integration.Table.Layout
{
    [TestClass]
    public class FullTableLayoutTest : IntegrationTest
    {
        private FullTableLayout _tableLayout;

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();
            OpenFullTable();
            _tableLayout = new FullTableLayout(Browser.GetDelegate(), "oneTable");
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

        [TestMethod]
        public void ReturnCorrectValueOfCellAtGivenRow()
        {
            Assert.AreEqual("Row 1 - Cell 2", _tableLayout.Value(1, 2));
        }

    }

}