using System;
using System.Collections.Generic;
using System.Text;
using Selenium;
using Caelum.SelenuimDSL;

namespace Caelum.SeleniumDSL
{
    public class Field : IField
    {
        private ISelenium selenium;
        private long timeout;
        private string name;

        public Field(ISelenium Selenium, long Timeout, string Name)
        {
            this.selenium = Selenium;
            this.timeout = Timeout;
            this.name = Name;
        }

        public IForm Type(string Content)
        {
            throw new NotImplementedException();
        }

        public bool Contains(string Content)
        {
            throw new NotImplementedException();
        }

        public string Content()
        {
            throw new NotImplementedException();
        }

        public void Blur()
        {
            throw new NotImplementedException();
        }

        public void Change()
        {
            throw new NotImplementedException();
        }

    }
}
