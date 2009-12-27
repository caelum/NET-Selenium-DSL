using Caelum.SeleniumDSL.Selector;
using Selenium;

namespace Caelum.SeleniumDSL.Default
{
    internal class SelectField : ISelectField
    {
        private readonly ISelenium _selenium;
        private readonly IForm _form;
        private readonly string _xpath;

        public SelectField(ISelenium selenium, IForm form, ISelector selector)
        {
            _selenium = selenium;
            _form = form;
            _xpath = string.Format("{0}/select{1}", form.Xpath, selector.GetExpression());
        }

        public IForm Choose(string value)
        {
            _selenium.Select(_xpath, value);
            return _form;
        }

        public IForm Choose(int index)
        {
            string[] options = _selenium.GetSelectOptions(_xpath);
            _selenium.Select(_xpath, options[index]);
            return _form;
        }

        public string Value()
        {
            return _selenium.GetValue(_xpath);
        }

        public string[] Values()
        {
            return _selenium.GetSelectOptions(_xpath);
        }

        public string Content()
        {
            return _selenium.GetSelectedLabel(_xpath);
        }

        public void Blur()
        {
            _selenium.FireEvent(_xpath, "blur");
        }

        public string Xpath
        {
            get { return _xpath; }
        }
    }
}