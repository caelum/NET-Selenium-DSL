using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class Field : IField
    {
        private readonly ISelenium _selenium;
        private readonly IForm _form;
        private readonly string _id;

        public Field(ISelenium selenium, IForm form, string id)
        {
            _selenium = selenium;
            _form = form;
            _id = id;
        }

        public IForm Type(string content)
        {
            _selenium.Type(_id, content);
            return _form;
        }

        public bool Contains(string content)
        {
            return _selenium.GetValue(_id).Contains(content);
        }

        public string Content()
        {
            return _selenium.GetValue(_id);
        }

        public void Blur()
        {
            _selenium.FireEvent(_id, "blur");
        }

        public void Change()
        {
            _selenium.FireEvent(_id, "change");
        }
    }
}