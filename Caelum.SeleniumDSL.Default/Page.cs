using Caelum.SeleniumDSL.Default.Selector;
using Caelum.SeleniumDSL.Default.Table.Layout;
using Caelum.SeleniumDSL.Selector;
using Caelum.SeleniumDSL.Table;
using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class Page : IPage
    {
        private readonly ISelenium _selenium;
        private readonly long _timeout;

        public Page(ISelenium selenium, long timeout)
        {
            _selenium = selenium;
            _timeout = timeout;
            _timeout = timeout;
        }

        public IForm Form(ISelector selector)
        {
            return new Form(_selenium, _timeout, selector);
        }

        public IContentTag Div(ISelector selector)
        {
            return new ContentTag(_selenium, selector);
        }

        public IContentTag Span(string id)
        {
            return new ContentTag(_selenium, Id.Is(id));
        }

        public ITable Table(string id)
        {
            var layout = new TableLayoutChooser(_selenium, id).GetLayout();
            return new Table.Table(_selenium, layout, id);
        }

        public IPage Navigate(string element)
        {
            _selenium.Click(element);
            _selenium.WaitForPageToLoad(_timeout.ToString());
            return this;
        }

        public IPage NavigateLink(string text)
        {
            return Navigate("link=" + text);
        }

        public IPage Click(string element)
        {
            _selenium.Click(element);
            return this;
        }

        public IPage ClickLink(string text)
        {
            return Click("link=" + text);
        }

        public IPage DoubleClick(string element)
        {
            _selenium.DoubleClick(element);
            return this;
        }

        public bool HasLink(string link)
        {
            return _selenium.IsTextPresent(link);
        }

        public string Title()
        {
            return _selenium.GetTitle();
        }

        //public System.Array Array(string Name)
        //{
        //    throw new System.NotImplementedException();
        //}

        public string Invoke(string cmd)
        {
            return _selenium.GetEval("this.browserbot.getCurrentWindow()." + cmd);
        }

        public IPage WaitUntil(string condition, long timeout)
        {
            _selenium.WaitForCondition("this.browserbot.getCurrentWindow()." + condition, timeout.ToString());
            return this;
        }

        public void Screenshot(string filePath)
        {
            _selenium.CaptureScreenshot(filePath);
        }

        public IPage Refresh()
        {
            _selenium.Refresh();
            return this;
        }

        public IPage MouseDown(string element)
        {
            _selenium.MouseDown(element);
            return this;
        }

        public IPage MouseUp(string element)
        {
            _selenium.MouseUp(element);
            return this;
        }

        public IPage DragAndDrop(string source, string destination)
        {
            _selenium.DragAndDrop(source, destination);
            return this;
        }

        public string Xpath
        {
            get { return "/"; }
        }
    }
}