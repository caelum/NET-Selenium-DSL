namespace Caelum.SelenuimDSL
{
    public interface IBrowser
    {
        IPage Open(string url);

        IPage CurrentPage();

        IPage WaitForPageLoad(long timeout);

        object GetDelegate();

        IPage Window(string id);
    }
}
