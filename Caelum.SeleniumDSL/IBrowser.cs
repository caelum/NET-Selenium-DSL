using Caelum.SelenuimDSL;
namespace Caelum.SeleniumDSL
{
    public interface IBrowser<T>
    {
        IPage Open(string url);

        IPage CurrentPage();

        IPage WaitForPageLoad(long timeout);

        T GetDelegate();

        IPage Window(string id);
    }
}
