using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class PageTest : UnitTest
    {
        private IPage _page;

        [TestInitialize]
        public new void SetUp()
        {
            base.SetUp();
            _page = new Page(Selenium.Object, 10000);
        }

        [TestMethod]
        public void TestClick()
        {
            Selenium.Setup(o => o.Click("someElement"));

            _page.Click("someElement");
        }

        [TestMethod]
        public void TestClickLink()
        {
            Selenium.Setup(o => o.Click("link=someElement"));

            _page.ClickLink("someElement");
        }

        [TestMethod]
        public void TestDoubleClick()
        {
            Selenium.Setup(o => o.DoubleClick("someElement"));

            _page.DoubleClick("someElement");
        }

        [TestMethod]
        public void TestDragAndDrop()
        {
            Selenium.Setup(o => o.DragAndDrop("from", "to"));

            _page.DragAndDrop("from", "to");
        }

        [TestMethod]
        public void TestHasLink()
        {
            Selenium.Setup(o => o.IsTextPresent("someLink"));

            _page.HasLink("someLink");
        }

        [TestMethod]
        public void TestInvoke()
        {
            Selenium.Setup(o => o.GetEval("this.browserbot.getCurrentWindow().someFunction()"));

            _page.Invoke("someFunction()");
        }

        [TestMethod]
        public void TestMouseDown()
        {
            Selenium.Setup(o => o.MouseDown("someElement"));

            _page.MouseDown("someElement");
        }

        [TestMethod]
        public void TestMouseUp()
        {
            Selenium.Setup(o => o.MouseUp("someElement"));

            _page.MouseUp("someElement");
        }

        [TestMethod]
        public void TestNavigate()
        {
            Selenium.Setup(o => o.Click("someLink"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            _page.Navigate("someLink");
        }

        [TestMethod]
        public void TestNavigateLink()
        {
            Selenium.Setup(o => o.Click("link=someLink"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            _page.NavigateLink("someLink");
        }

        [TestMethod]
        public void TestRefresh()
        {
            Selenium.Setup(o => o.Refresh());

            _page.Refresh();
        }

        [TestMethod]
        public void TestScreenshot()
        {
            Selenium.Setup(o => o.CaptureScreenshot("someFilePath"));

            _page.Screenshot("someFilePath");
        }

        [TestMethod]
        public void TestTitle()
        {
            Selenium.Setup(o => o.GetTitle());

            _page.Title();
        }

        [TestMethod]
        public void TestWaitUntil()
        {
            Selenium.Setup(o => o.WaitForCondition("this.browserbot.getCurrentWindow().prop === true", "3000"));

            _page.WaitUntil("prop === true", 3000);
        }
    }
}