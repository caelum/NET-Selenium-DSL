namespace Caelum.SeleniumDSL
{
    public interface ISelectField : IElement
    {
        IForm Choose(string value);

        IForm Choose(int index);

        string Value();

        string[] Values();

        string Content();

        void Blur();
    }
}