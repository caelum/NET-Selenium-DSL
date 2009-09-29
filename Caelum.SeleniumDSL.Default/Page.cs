using Caelum.SeleniumDSL.Default.Table.Layout;
using Caelum.SeleniumDSL.Table;
using Caelum.SeleniumDSL.Table.Layout;
using Selenium;
using TableSpace = Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL.Default
{
    internal class Page : IPage
    {
        private readonly ISelenium selenium;
        private readonly long timeout;

        public Page(ISelenium selenium, long timeout)
        {
            this.selenium = selenium;
            this.timeout = timeout;
        }

        public IForm Form(string id)
        {
            return new Form(selenium, timeout, id);
        }

        public IContentTag Div(string id)
        {
            return new ContentTag(selenium, id);
        }

        public IContentTag Span(string id)
        {
            return new ContentTag(selenium, id);
        }

        public ITable Table(string id)
        {
            ITableLayout layout = new FullTableLayout(selenium, id);
            return new Default.Table.Table(selenium, layout, id);
        }

        public IPage Navigate(string element)
        {
            selenium.Click(element);
            selenium.WaitForPageToLoad(timeout.ToString());
            return this;
        }

        public IPage NavigateLink(string text)
        {
            return Navigate("link=" + text);
        }

        public IPage Click(string element)
        {
            selenium.Click(element);
            return this;
        }

        public IPage ClickLink(string text)
        {
            return Click("link=" + text);
        }

        public IPage DoubleClick(string element)
        {
            selenium.DoubleClick(element);
            return this;
        }

        public bool HasLink(string link)
        {
            return selenium.IsTextPresent(link);
        }

        public string Title()
        {
            return selenium.GetTitle();
        }

        //public System.Array Array(string Name)
        //{
        //    throw new System.NotImplementedException();
        //}

        public string Invoke(string cmd)
        {
            return selenium.GetEval("this.browserbot.getCurrentWindow()." + cmd);
        }

        public IPage WaitUntil(string condition, long timeout)
        {
            selenium.WaitForCondition("this.browserbot.getCurrentWindow()." + condition, timeout.ToString());
            return this;
        }

        public void Screenshot(string filePath)
        {
            selenium.CaptureScreenshot(filePath);
        }

        public IPage Refresh()
        {
            selenium.Refresh();
            return this;
        }

        public IPage MouseDown(string element)
        {
            selenium.MouseDown(element);
            return this;
        }

        public IPage MouseUp(string element)
        {
            selenium.MouseUp(element);
            return this;
        }

        public IPage DragAndDrop(string source, string destination)
        {
            selenium.DragAndDrop(source, destination);
            return this;
        }
    }
}