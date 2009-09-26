namespace Caelum.SeleniumDSL
{
    public interface IField
    {
        IForm Type(string Content);

        bool Contains(string Content);

        string Content();

        void Blur();

        void Change();
    }
}
