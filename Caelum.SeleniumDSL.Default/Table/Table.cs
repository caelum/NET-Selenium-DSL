using System;
using Caelum.SeleniumDSL.Search;
using Caelum.SeleniumDSL.Table;
using Caelum.SeleniumDSL.Table.Layout;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Table
{
    internal class Table : ITable
    {
        private ISelenium _selenium;
        private readonly ITableLayout _layout;
        private string _id;

        public Table(ISelenium selenium, ITableLayout layout, string id)
        {
            _selenium = selenium;
            _layout = layout;
            _id = id;
        }

        public new string GetType()
        {
            throw new NotImplementedException();
        }

        public IColumn Column(int columnIndex)
        {
            return new Column(this, columnIndex);
        }

        public IColumn Column(string columnName)
        {
            throw new NotImplementedException();
        }

        public int GetColumnCount()
        {
            return _layout.GetColumnCount();
        }

        public int GetRowCount()
        {
            return _layout.GetRowCount();
        }

        public int GetContentCount()
        {
            return _layout.GetContentCount();
        }

        public IRow Header()
        {
            throw new NotImplementedException();
        }

        public IRow Row(int row)
        {
            throw new NotImplementedException();
        }

        public ICell Cell(int row, int col)
        {
            throw new NotImplementedException();
        }

        public ICell Cell(int row, string col)
        {
            throw new NotImplementedException();
        }

        public string GetId()
        {
            throw new NotImplementedException();
        }

        public bool Exists()
        {
            throw new NotImplementedException();
        }

        public void Iterate(IRowVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public int FindColumn(string columnName)
        {
            throw new NotImplementedException();
        }

        public IRowMatcher Select(IRowMatcher matcher)
        {
            throw new NotImplementedException();
        }

        public bool Contains(ITable table, string column, string content)
        {
            throw new NotImplementedException();
        }
    }
}