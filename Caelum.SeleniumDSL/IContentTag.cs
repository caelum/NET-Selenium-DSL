namespace Caelum.SeleniumDSL
{
    public interface IContentTag : IElement
    {
        bool Contains(string content);

        bool Exists();

        string InnerHtml();
    }
}