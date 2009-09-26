using System;
using System.Collections.Generic;
using Caelum.SelenuimDSL;
using Selenium;

namespace Caelum.SeleniumDSL
{
    internal class SelectField : ISelectField
    {
        private ISelenium selenium;
        private IForm form;
        private string id;

        public SelectField(ISelenium selenium, IForm form, string id)
        {
            this.selenium = selenium;
            this.form = form;
            this.id = id;
        }

        public IForm Choose(string value)
        {
            selenium.Select(id, value);
            return form;
        }

        public IForm Choose(int index)
        {
            string[] options = selenium.GetSelectOptions(id);
            selenium.Select(id, options[index]);
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
