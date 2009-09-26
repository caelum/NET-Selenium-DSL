namespace Caelum.SeleniumDSL
{
    public interface IContentTag
    {
        bool Contains(string Content);

        bool Exists();

        string InnerHTML();
    }
}
