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

        public void Click(string element)
        {
            _selenium.Click(element);
        }

        public void Navigate(string element)
        {
            _selenium.Click(element);
            _selenium.WaitForPageToLoad(_timeout.ToString());
        }

        public ISelectField Select(string selectField)
        {
            return new SelectField(_selenium, this, selectField);
        }

        public IForm Check(string checkbox)
        {
            _selenium.Check(checkbox);
            return this;
        }

        public IForm Uncheck(string checkbox)
        {
            _selenium.Uncheck(checkbox);
            return this;
        }

        public bool IsChecked(string checkbox)
        {
            return _selenium.IsChecked(checkbox);
        }

        public IPage Submit()
        {
            _selenium.Submit(_xpath);
            _selenium.WaitForPageToLoad(_timeout.ToString());
            return new Page(_selenium, _timeout);
        }
    }
}