using System;
using System.Collections.Generic;
using System.Text;
using Selenium;
using Caelum.SeleniumDSL;

namespace Caelum.SeleniumDSL.Table
{
    public class Table : ITable
    {
        private ISelenium selenium;
        private string id;

        public Table(ISelenium Selenium, string Id)
        {
            this.selenium = Selenium;
            this.id = Id;
        }

        #region ITable Members

        public new string GetType()
        {
            throw new NotImplementedException();
        }

        public Caelum.SeleniumDSL.Table.IColumn Column(int ColumnIndex)
        {
            throw new NotImplementedException();
        }

        public Caelum.SeleniumDSL.Table.IColumn Column(string ColumnName)
        {
            throw new NotImplementedException();
        }

        public int GetColCount()
        {
            throw new NotImplementedException();
        }

        public int GetRowCount()
        {
            throw new NotImplementedException();
        }

        public int GetContentCount()
        {
            throw new NotImplementedException();
        }

        public Caelum.SeleniumDSL.Table.IRow Header()
        {
            throw new NotImplementedException();
        }

        public Caelum.SeleniumDSL.Table.IRow Row(int Row)
        {
            throw new NotImplementedException();
        }

        public Caelum.SeleniumDSL.Table.ICell Cell(int Row, int Col)
        {
            throw new NotImplementedException();
        }

        public Caelum.SeleniumDSL.Table.ICell Cell(int Row, string Col)
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

        public void Iterate(Caelum.SeleniumDSL.Search.IRowVisitor Visitor)
        {
            throw new NotImplementedException();
        }

        public int FindColumn(string ColumnName)
        {
            throw new NotImplementedException();
        }

        public Caelum.SeleniumDSL.Search.IRowMatcher Select(Caelum.SeleniumDSL.Search.IRowMatcher Matcher)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
