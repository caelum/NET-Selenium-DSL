namespace Caelum.SeleniumDSL
{
    public interface IForm
    {
        IField Field(string field);

        void Click(string element);

        void Navigate(string element);

        ISelectField Select(string selectField);

        IForm Check(string checkbox);

        IForm Uncheck(string checkbox);

        bool IsChecked(string checkbox);

        void Submit();
    }
}