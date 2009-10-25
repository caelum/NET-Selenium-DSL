namespace Caelum.SeleniumDSL.Table.Layout
{
    public interface ITableLayout
    {
        string HeaderValue(int column);

        string HeaderLinkValue(int column);

        int GetContentCount();

        string Value(int row, int column);

        int GetColumnCount();

        int GetRowCount();

        
    }
}