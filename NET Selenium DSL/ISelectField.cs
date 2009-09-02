namespace Caelum.SelenuimDSL
{
    public interface ISelectField
    {
        IForm Choose(string Value);

        IForm Choose(int Index);

        string Value();

        string[] Values();

        string Content();

        void Blur();
    }
}
