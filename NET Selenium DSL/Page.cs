using Caelum.SelenuimDSL;
using Selenium;

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
            throw new System.NotImplementedException();
        }

        public IContentTag Span(string Id)
        {
            throw new System.NotImplementedException();
        }

        public ITable Table(string Id)
        {
            throw new System.NotImplementedException();
        }

        public IPage Navigate(string Element)
        {
            throw new System.NotImplementedException();
        }

        public IPage NavigateLink(string Text)
        {
            throw new System.NotImplementedException();
        }

        public IPage Click(string Element)
        {
            throw new System.NotImplementedException();
        }

        public IPage ClickLink(string Text)
        {
            throw new System.NotImplementedException();
        }

        public IPage DoubleClick(string Element)
        {
            throw new System.NotImplementedException();
        }

        public bool HasLink(string Link)
        {
            throw new System.NotImplementedException();
        }

        public string Title()
        {
            throw new System.NotImplementedException();
        }

        public System.Array Array(string Name)
        {
            throw new System.NotImplementedException();
        }

        public string Invoke(string Cmd)
        {
            throw new System.NotImplementedException();
        }

        public IPage WaitUntil(string Condition, long Timeout)
        {
            throw new System.NotImplementedException();
        }

        public void Screenshot(string FileName)
        {
            throw new System.NotImplementedException();
        }

        public IPage Refresh()
        {
            throw new System.NotImplementedException();
        }

        public IPage MouseDown(string Element)
        {
            throw new System.NotImplementedException();
        }

        public IPage MouseUp(string Element)
        {
            throw new System.NotImplementedException();
        }

        public IPage DragAndDrop(string FromElement, string ToElement)
        {
            throw new System.NotImplementedException();
        }

    }
}
