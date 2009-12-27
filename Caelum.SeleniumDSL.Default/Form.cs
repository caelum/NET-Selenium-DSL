using Caelum.SeleniumDSL.Default.Selector;
using Caelum.SeleniumDSL.Selector;
using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class Form : IForm
    {
        private readonly ISelenium _selenium;
        private readonly long _timeout;
        private readonly string _xpath;

        public virtual string Xpath
        {
            get { return _xpath; }
        }

        public Form(ISelenium selenium, long timeout, ISelector selector)
        {
            _selenium = selenium;
            _timeout = timeout;
            _xpath = string.Format("//form{0}", selector.GetExpression());
        }

        public IField Field(string name)
        {
            return new Field(_selenium, this, name);
        }

        public void Click(string name)
        {
            _selenium.Click(string.Format("{0}/*[@name='{1}']", _xpath, name));
        }

        public void Navigate(string element)
        {
            _selenium.Click(string.Format("{0}/*[@name='{1}']", _xpath, element));
            _selenium.WaitForPageToLoad(_timeout.ToString());
        }

        public ISelectField Select(string name)
        {
            return new SelectField(_selenium, this, Name.Is(name));
        }

        public IForm Check(string name)
        {
            _selenium.Check(string.Format("{0}/input[@name='{1}']", _xpath, name));
            return this;
        }

        public IForm Uncheck(string checkbox)
        {
            _selenium.Uncheck(string.Format("{0}/*[@name='{1}']", _xpath, checkbox));
            return this;
        }

        public bool IsChecked(string checkbox)
        {
            return _selenium.IsChecked(string.Format("{0}/*[@name='{1}']", _xpath, checkbox));
        }

        public IPage Submit()
        {
            _selenium.Submit(_xpath);
            _selenium.WaitForPageToLoad(_timeout.ToString());
            return new Page(_selenium, _timeout);
        }
    }
}