using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caelum.SeleniumDSL;

namespace Unit.Caelum.SeleniumDSL
{
    [TestClass]
    public class PageTest : UnitTest
    {
        [TestMethod]
        public void TestClick()
        {
            selenium.Setup(o => o.Click("someElement"));

            Page page = new Page(selenium.Object, 10000);

            page.Click("someElement");
        }

        [TestMethod]
        public void TestClickLink()
        {
            selenium.Setup(o => o.Click("link=someElement"));

            Page page = new Page(selenium.Object, 10000);

            page.ClickLink("someElement");
        }

        [TestMethod]
        public void TestDoubleClick()
        {
            selenium.Setup(o => o.DoubleClick("someElement"));

            Page page = new Page(selenium.Object, 10000);

            page.DoubleClick("someElement");
        }

        [TestMethod]
        public void TestDragAndDrop()
        {
            selenium.Setup(o => o.DragAndDrop("from", "to"));

            Page page = new Page(selenium.Object, 10000);

            page.DragAndDrop("from", "to");
        }

        [TestMethod]
        public void TestHasLink()
        {
            selenium.Setup(o => o.IsTextPresent("someLink"));

            Page page = new Page(selenium.Object, 10000);

            page.HasLink("someLink");
        }

        [TestMethod]
        public void TestInvoke()
        {
            selenium.Setup(o => o.GetEval("this.browserbot.getCurrentWindow().someFunction()"));

            Page page = new Page(selenium.Object, 10000);

            page.Invoke("someFunction()");
        }

        [TestMethod]
        public void TestMouseDown()
        {
            selenium.Setup(o => o.MouseDown("someElement"));

            Page page = new Page(selenium.Object, 10000);

            page.MouseDown("someElement");
        }

        [TestMethod]
        public void TestMouseUp()
        {
            selenium.Setup(o => o.MouseUp("someElement"));

            Page page = new Page(selenium.Object, 10000);

            page.MouseUp("someElement");
        }

        [TestMethod]
        public void TestNavigate()
        {
            selenium.Setup(o => o.Click("someLink"));
            selenium.Setup(o => o.WaitForPageToLoad("10000"));

            Page page = new Page(selenium.Object, 10000);

            page.Navigate("someLink");
        }

        [TestMethod]
        public void TestNavigateLink()
        {
            selenium.Setup(o => o.Click("link=someLink"));
            selenium.Setup(o => o.WaitForPageToLoad("10000"));

            Page page = new Page(selenium.Object, 10000);

            page.NavigateLink("someLink");
        }

        [TestMethod]
        public void TestRefresh()
        {
            selenium.Setup(o => o.Refresh());

            Page page = new Page(selenium.Object, 10000);

            page.Refresh();
        }

        [TestMethod]
        public void TestScreenshot()
        {
            selenium.Setup(o => o.CaptureScreenshot("someFilePath"));

            Page page = new Page(selenium.Object, 10000);

            page.Screenshot("someFilePath");
        }

        [TestMethod]
        public void TestTitle()
        {
            selenium.Setup(o => o.GetTitle());

            Page page = new Page(selenium.Object, 10000);

            page.Title();
        }

        [TestMethod]
        public void TestWaitUntil()
        {
            selenium.Setup(o => o.WaitForCondition("this.browserbot.getCurrentWindow().prop === true", "3000"));

            Page page = new Page(selenium.Object, 10000);

            page.WaitUntil("prop === true", 3000);
        }
    }
}
