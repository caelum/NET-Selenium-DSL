using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caelum.SeleniumDSL.Table.Layout
{
    public interface ITableLayout
    {
        string HeaderValue(int Column);

        string HeaderLinkValue(int Column);

        int GetContentCount();

        string Value(int Row, int Column);

        int GetColumnCount();

        int GetRowCount();

        bool Contains(ITable Table, string Column, string Content);
    }
}
