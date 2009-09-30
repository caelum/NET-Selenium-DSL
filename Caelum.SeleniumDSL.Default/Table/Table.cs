using System;
using Caelum.SeleniumDSL.Search;
using Caelum.SeleniumDSL.Table;
using Caelum.SeleniumDSL.Table.Layout;
using Selenium;

namespace Caelum.SeleniumDSL.Default.Table
{
    internal class Table : ITable
    {
        private ISelenium selenium;
        private readonly ITableLayout layout;
        private string id;

        public Table(ISelenium selenium, ITableLayout layout, string id)
        {
            this.selenium = selenium;
            this.layout = layout;
            this.id = id;
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
            return layout.GetColumnCount();
        }

        public int GetRowCount()
        {
            return layout.GetRowCount();
        }

        public int GetContentCount()
        {
            return layout.GetContentCount();
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
    }
}