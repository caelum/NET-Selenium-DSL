using System;
using System.Collections.Generic;
using Caelum.SelenuimDSL;
using Selenium;

namespace Caelum.SeleniumDSL
{
    public class SelectField : ISelectField
    {
        private ISelenium selenium;
        private IForm form;
        private string id;

        public SelectField(ISelenium Selenium, IForm Form, string Id)
        {
            this.selenium = Selenium;
            this.form = Form;
            this.id = Id;
        }

        public IForm Choose(string Value)
        {
            selenium.Select(id, Value);
            return form;
        }

        public IForm Choose(int Index)
        {
            string[] options = selenium.GetSelectOptions(id);
            selenium.Select(id, options[Index]);
            return form;
        }

        public string Value()
        {
            return selenium.GetValue(id);
        }

        public string[] Values()
        {
            return selenium.GetSelectOptions(id);
        }

        public string Content()
        {
            return selenium.GetSelectedLabel(id);
        }

        public void Blur()
        {
            selenium.FireEvent(id, "blur");
        }

    }
}
