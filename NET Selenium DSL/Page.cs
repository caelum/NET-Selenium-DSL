using Caelum.SelenuimDSL;
using Selenium;
using TableSpace = Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL
{
    public class Page : IPage
    {
        private ISelenium selenium;
        private long timeout;

        public Page(ISelenium Selenium, long Timeout)
        {
            this.selenium = Selenium;
            this.timeout = Timeout;
        }

        public IForm Form(string Id)
        {
            return new Form(selenium, timeout, Id);
        }

        public IContentTag Div(string Id)
        {
            return new ContentTag(selenium, Id);
        }

        public IContentTag Span(string Id)
        {
            return new ContentTag(selenium, Id);
        }

        public ITable Table(string Id)
        {
            return new TableSpace::Table(selenium, Id);
        }

        public IPage Navigate(string Element)
        {
            selenium.Click(Element);
            selenium.WaitForPageToLoad(timeout.ToString());
            return this;
        }

        public IPage NavigateLink(string Text)
        {
            return Navigate("link="+Text);
        }

        public IPage Click(string Element)
        {
            selenium.Click(Element);
            return this;
        }

        public IPage ClickLink(string Text)
        {
            return Click("link=" + Text);
        }

        public IPage DoubleClick(string Element)
        {
            selenium.DoubleClick(Element);
            return this;
        }

        public bool HasLink(string Link)
        {
            return selenium.IsTextPresent(Link);
        }

        public string Title()
        {
            return selenium.GetTitle();
        }

        //public System.Array Array(string Name)
        //{
        //    throw new System.NotImplementedException();
        //}

        public string Invoke(string Cmd)
        {
            return selenium.GetEval("this.browserbot.getCurrentWindow()." + Cmd);
        }

        public IPage WaitUntil(string Condition, long Timeout)
        {
            selenium.WaitForCondition("this.browserbot.getCurrentWindow()." + Condition, Timeout.ToString());
            return this;
        }

        public void Screenshot(string FileName)
        {
            selenium.CaptureScreenshot(FileName);
        }

        public IPage Refresh()
        {
            selenium.Refresh();
            return this;
        }

        public IPage MouseDown(string Element)
        {
            selenium.MouseDown(Element);
            return this;
        }

        public IPage MouseUp(string Element)
        {
            selenium.MouseUp(Element);
            return this;
        }

        public IPage DragAndDrop(string FromElement, string ToElement)
        {
            selenium.DragAndDrop(FromElement, ToElement);
            return this;
        }

    }
}
