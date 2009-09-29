using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class Field : IField
    {
        private readonly ISelenium selenium;
        private readonly IForm form;
        private readonly string id;

        public Field(ISelenium Selenium, IForm Form, string Id)
        {
            this.selenium = Selenium;
            this.form = Form;
            this.id = Id;
        }

        public IForm Type(string Content)
        {
            selenium.Type(id, Content);
            return form;
        }

        public bool Contains(string Content)
        {
            return selenium.GetValue(id).Contains(Content);
        }

        public string Content()
        {
            return selenium.GetValue(id);
        }

        public void Blur()
        {
            selenium.FireEvent(id, "blur");
        }

        public void Change()
        {
            selenium.FireEvent(id, "change");
        }
    }
}