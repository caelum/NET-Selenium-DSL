using System;
using Caelum.SelenuimDSL;
using Selenium;
using System.Threading;

namespace Caelum.SeleniumDSL
{
    internal class Form : IForm
    {
        private ISelenium selenium;
        private long timeout;
        private string id;

        public Form(ISelenium selenium, long timeout, string id)
        {
            this.selenium = selenium;
            this.timeout = timeout;
            this.id = id;
        }

        public IField Field(string field)
        {
            return new Field(selenium, this, field);
        }

        public void Click(string element)
        {
            selenium.Click(element);
        }

        public void Navigate(string element)
        {
            selenium.Click(element);
            selenium.WaitForPageToLoad(timeout.ToString());
        }

        public ISelectField Select(string selectField)
        {
            return new SelectField(selenium, this, selectField);
        }

        public IForm Check(string checkbox)
        {
            selenium.Check(checkbox);
            return this;
        }

        public IForm Uncheck(string checkbox)
        {
            selenium.Uncheck(checkbox);
            return this;
        }

        public bool IsChecked(string checkbox)
        {
            return selenium.IsChecked(checkbox);
        }

        public void Submit()
        {
            selenium.Submit(this.id);
            selenium.WaitForPageToLoad(timeout.ToString());
        }

    }
}
