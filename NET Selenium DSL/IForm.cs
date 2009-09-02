using Caelum.SeleniumDSL;
namespace Caelum.SelenuimDSL
{
    public interface IForm
    {
        IField Field(string Field);

        void Click(string Element);

        void Navigate(string Element);

        ISelectField Select(string SelectField);

        IForm Check(string Checkbox);

        IForm Uncheck(string Checkbox);

        bool IsChecked(string Checkbox);

        void Submit();
    }
}
