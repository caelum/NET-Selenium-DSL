namespace Caelum.SeleniumDSL.Table
{
    public interface ICell
    {
        string Value();

        string GetLink();

        string HeaderValue();

        string HeaderLinkValue();

        ICell Check();

        ICell Uncheck();

        bool Checked();

        bool Contains(string content);
    }
}