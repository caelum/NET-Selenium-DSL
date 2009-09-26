using System;

namespace Caelum.SeleniumDSL.Table
{
    public interface IRow
    {
        ICell Cell(int Column);

        ICell Cell(String Column);

        int Index();
    }
}
