using System;
using Caelum.SelenuimDSL;
using Selenium;

namespace Caelum.SeleniumDSL
{
    public class Form : IForm
    {
        private ISelenium selenium;
        private long timeout;
        private string id;

        public Form(ISelenium Selenium, long Timeout, string Id)
        {
            this.selenium = Selenium;
            this.timeout = Timeout;
            this.id = Id;
        }

        public IField Field(string Field)
        {
            return new Field(selenium, timeout, Field);
        }

        public void Click(string Element)
        {
            selenium.Click(Element);
        }

        public void Navigate(string Element)
        {
            selenium.Click(Element);
            selenium.WaitForPageToLoad(timeout.ToString());
        }

        public ISelectField Select(string SelectField)
        {
            throw new NotImplementedException();
        }

        public IForm Check(string Checkbox)
        {
            throw new NotImplementedException();
        }

        public IForm Uncheck(string Checkbox)
        {
            throw new NotImplementedException();
        }

        public bool IsChecked(string Checkbox)
        {
            throw new NotImplementedException();
        }

        public void Submit()
        {
            selenium.Submit(this.id);
            selenium.WaitForPageToLoad(timeout.ToString());
        }

    }
}
