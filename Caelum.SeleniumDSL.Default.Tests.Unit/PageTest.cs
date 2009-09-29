﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit
{
    [TestClass]
    public class PageTest : UnitTest
    {
        [TestMethod]
        public void TestClick()
        {
            selenium.Setup(o => o.Click("someElement"));

            var page = new Page(selenium.Object, 10000);

            page.Click("someElement");
        }

        [TestMethod]
        public void TestClickLink()
        {
            selenium.Setup(o => o.Click("link=someElement"));

            var page = new Page(selenium.Object, 10000);

            page.ClickLink("someElement");
        }

        [TestMethod]
        public void TestDoubleClick()
        {
            selenium.Setup(o => o.DoubleClick("someElement"));

            var page = new Page(selenium.Object, 10000);

            page.DoubleClick("someElement");
        }

        [TestMethod]
        public void TestDragAndDrop()
        {
            selenium.Setup(o => o.DragAndDrop("from", "to"));

            var page = new Page(selenium.Object, 10000);

            page.DragAndDrop("from", "to");
        }

        [TestMethod]
        public void TestHasLink()
        {
            selenium.Setup(o => o.IsTextPresent("someLink"));

            var page = new Page(selenium.Object, 10000);

            page.HasLink("someLink");
        }

        [TestMethod]
        public void TestInvoke()
        {
            selenium.Setup(o => o.GetEval("this.browserbot.getCurrentWindow().someFunction()"));

            var page = new Page(selenium.Object, 10000);

            page.Invoke("someFunction()");
        }

        [TestMethod]
        public void TestMouseDown()
        {
            selenium.Setup(o => o.MouseDown("someElement"));

            var page = new Page(selenium.Object, 10000);

            page.MouseDown("someElement");
        }

        [TestMethod]
        public void TestMouseUp()
        {
            selenium.Setup(o => o.MouseUp("someElement"));

            var page = new Page(selenium.Object, 10000);

            page.MouseUp("someElement");
        }

        [TestMethod]
        public void TestNavigate()
        {
            selenium.Setup(o => o.Click("someLink"));
            selenium.Setup(o => o.WaitForPageToLoad("10000"));

            var page = new Page(selenium.Object, 10000);

            page.Navigate("someLink");
        }

        [TestMethod]
        public void TestNavigateLink()
        {
            selenium.Setup(o => o.Click("link=someLink"));
            selenium.Setup(o => o.WaitForPageToLoad("10000"));

            var page = new Page(selenium.Object, 10000);

            page.NavigateLink("someLink");
        }

        [TestMethod]
        public void TestRefresh()
        {
            selenium.Setup(o => o.Refresh());

            var page = new Page(selenium.Object, 10000);

            page.Refresh();
        }

        [TestMethod]
        public void TestScreenshot()
        {
            selenium.Setup(o => o.CaptureScreenshot("someFilePath"));

            var page = new Page(selenium.Object, 10000);

            page.Screenshot("someFilePath");
        }

        [TestMethod]
        public void TestTitle()
        {
            selenium.Setup(o => o.GetTitle());

            var page = new Page(selenium.Object, 10000);

            page.Title();
        }

        [TestMethod]
        public void TestWaitUntil()
        {
            selenium.Setup(o => o.WaitForCondition("this.browserbot.getCurrentWindow().prop === true", "3000"));

            var page = new Page(selenium.Object, 10000);

            page.WaitUntil("prop === true", 3000);
        }
    }
}