using Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL.Default.Table
{
    internal class Cell : ICell
    {
        private readonly Table _table;
        private readonly int _row;
        private readonly int _column;

        public Cell(Table table, int row, int column)
        {
            _table = table;
            _row = row;
            _column = column;
        }

        public string Value()
        {
            return _table.Layout.Value(_row, _column);
        }   

        //public string GetLink()
        //{
        //    // TODO: implement without Javascript
        //    return _selenium.GetEval("dom=selenium.page().findElement('{}/a').href");
        //}

        //public string HeaderValue()
        //{
        //    throw new NotImplementedException();
        //}

        //public string HeaderLinkValue()
        //{
        //    throw new NotImplementedException();
        //}

        //public ICell Check()
        //{
        //    throw new NotImplementedException();
        //}

        //public ICell Uncheck()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Checked()
        //{
        //    throw new NotImplementedException();
        //}

        public bool Contains(string text)
        {
            return _table.Layout.Value(_row, _column).Contains(text);
        }
    }
}