using Caelum.SeleniumDSL.Selector;
using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class Form : IForm
    {
        private readonly ISelenium _selenium;
        private readonly long _timeout;
        private readonly ISelector _selector;

        public Form(ISelenium selenium, long timeout, ISelector selector)
        {
            _selenium = selenium;
            _timeout = timeout;
            _selector = selector;
        }

        public IField Field(string field)
        {
            return new Field(_selenium, this, field);
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

        public void Submit()
        {
            _selenium.Submit(string.Format("//form{0}", _selector.GetExpression()));
            _selenium.WaitForPageToLoad(_timeout.ToString());
        }
    }
}