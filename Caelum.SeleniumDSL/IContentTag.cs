namespace Caelum.SeleniumDSL
{
    public interface IContentTag
    {
        bool Contains(string content);

        bool Exists();

        string InnerHtml();
    }
}