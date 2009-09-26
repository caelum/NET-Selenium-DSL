namespace Caelum.SeleniumDSL
{
    public interface ISelectField
    {
        IForm Choose(string value);

        IForm Choose(int index);

        string Value();

        string[] Values();

        string Content();

        void Blur();
    }
}
