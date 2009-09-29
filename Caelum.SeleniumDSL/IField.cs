namespace Caelum.SeleniumDSL
{
    public interface IField
    {
        IForm Type(string content);

        bool Contains(string content);

        string Content();

        void Blur();

        void Change();
    }
}