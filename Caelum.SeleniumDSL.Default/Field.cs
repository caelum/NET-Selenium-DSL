using System;
using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class Field : IField
    {
        private readonly ISelenium _selenium;
        private readonly IForm _form;
        private readonly string _xpath;

        public Field(ISelenium selenium, IForm form, string name)
        {
            _selenium = selenium;
            _form = form;
            _xpath = string.Format("{0}/input[@name='{1}']", _form.Xpath, name);
        }

        public IForm Type(string content)
        {
            _selenium.Type(_xpath, content);
            return _form;
        }

        public bool Contains(string content)
        {
            return _selenium.GetValue(_xpath).Contains(content);
        }

        public string Content()
        {
            return _selenium.GetValue(_xpath);
        }

        public void Blur()
        {
            _selenium.FireEvent(_xpath, "blur");
        }

        public void Change()
        {
            _selenium.FireEvent(_xpath, "change");
        }

        public string Xpath
        {
            get { return _xpath; }
        }
    }
}