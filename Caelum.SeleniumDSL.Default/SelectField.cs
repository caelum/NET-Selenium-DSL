using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class SelectField : ISelectField
    {
        private readonly ISelenium _selenium;
        private readonly IForm _form;
        private readonly string _id;

        public SelectField(ISelenium selenium, IForm form, string id)
        {
            _selenium = selenium;
            _form = form;
            _id = id;
        }

        public IForm Choose(string value)
        {
            _selenium.Select(_id, value);
            return _form;
        }

        public IForm Choose(int index)
        {
            string[] options = _selenium.GetSelectOptions(_id);
            _selenium.Select(_id, options[index]);
            return _form;
        }

        public string Value()
        {
            return _selenium.GetValue(_id);
        }

        public string[] Values()
        {
            return _selenium.GetSelectOptions(_id);
        }

        public string Content()
        {
            return _selenium.GetSelectedLabel(_id);
        }

        public void Blur()
        {
            _selenium.FireEvent(_id, "blur");
        }
    }
}