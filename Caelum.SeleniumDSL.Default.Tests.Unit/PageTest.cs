using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class PageTest : UnitTest
    {
        [TestMethod]
        public void TestClick()
        {
            Selenium.Setup(o => o.Click("someElement"));

            var page = new Page(Selenium.Object, 10000);

            page.Click("someElement");
        }

        [TestMethod]
        public void TestClickLink()
        {
            Selenium.Setup(o => o.Click("link=someElement"));

            var page = new Page(Selenium.Object, 10000);

            page.ClickLink("someElement");
        }

        [TestMethod]
        public void TestDoubleClick()
        {
            Selenium.Setup(o => o.DoubleClick("someElement"));

            var page = new Page(Selenium.Object, 10000);

            page.DoubleClick("someElement");
        }

        [TestMethod]
        public void TestDragAndDrop()
        {
            Selenium.Setup(o => o.DragAndDrop("from", "to"));

            var page = new Page(Selenium.Object, 10000);

            page.DragAndDrop("from", "to");
        }

        [TestMethod]
        public void TestHasLink()
        {
            Selenium.Setup(o => o.IsTextPresent("someLink"));

            var page = new Page(Selenium.Object, 10000);

            page.HasLink("someLink");
        }

        [TestMethod]
        public void TestInvoke()
        {
            Selenium.Setup(o => o.GetEval("this.browserbot.getCurrentWindow().someFunction()"));

            var page = new Page(Selenium.Object, 10000);

            page.Invoke("someFunction()");
        }

        [TestMethod]
        public void TestMouseDown()
        {
            Selenium.Setup(o => o.MouseDown("someElement"));

            var page = new Page(Selenium.Object, 10000);

            page.MouseDown("someElement");
        }

        [TestMethod]
        public void TestMouseUp()
        {
            Selenium.Setup(o => o.MouseUp("someElement"));

            var page = new Page(Selenium.Object, 10000);

            page.MouseUp("someElement");
        }

        [TestMethod]
        public void TestNavigate()
        {
            Selenium.Setup(o => o.Click("someLink"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            var page = new Page(Selenium.Object, 10000);

            page.Navigate("someLink");
        }

        [TestMethod]
        public void TestNavigateLink()
        {
            Selenium.Setup(o => o.Click("link=someLink"));
            Selenium.Setup(o => o.WaitForPageToLoad("10000"));

            var page = new Page(Selenium.Object, 10000);

            page.NavigateLink("someLink");
        }

        [TestMethod]
        public void TestRefresh()
        {
            Selenium.Setup(o => o.Refresh());

            var page = new Page(Selenium.Object, 10000);

            page.Refresh();
        }

        [TestMethod]
        public void TestScreenshot()
        {
            Selenium.Setup(o => o.CaptureScreenshot("someFilePath"));

            var page = new Page(Selenium.Object, 10000);

            page.Screenshot("someFilePath");
        }

        [TestMethod]
        public void TestTitle()
        {
            Selenium.Setup(o => o.GetTitle());

            var page = new Page(Selenium.Object, 10000);

            page.Title();
        }

        [TestMethod]
        public void TestWaitUntil()
        {
            Selenium.Setup(o => o.WaitForCondition("this.browserbot.getCurrentWindow().prop === true", "3000"));

            var page = new Page(Selenium.Object, 10000);

            page.WaitUntil("prop === true", 3000);
        }
    }
}