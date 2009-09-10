using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caelum.SelenuimDSL;
using Caelum.SeleniumDSL;

namespace Integration.Caelum.SeleniumDSL
{
    [TestClass]
    public class FieldTest : IntegrationTest
    {
        [TestMethod]
        public void TestBlur()
        {
            openEvents();
            IPage page = browser.CurrentPage();

            page.Form("oneForm").Field("blurInput").Blur();

            Assert.IsTrue(page.Div("oneDiv").Contains("blur"));
        }

        [TestMethod]
        public void TestChange()
        {
            openEvents();
            IPage page = browser.CurrentPage();

            page.Form("oneForm").Field("changeInput").Change();

            Assert.IsTrue(page.Div("oneDiv").Contains("change"));
        }

        [TestMethod]
        public void TestThatTypeValueInsideField()
        {
            openEvents();
            IField field = browser.CurrentPage().Form("oneForm").Field("changeInput");
            
            field.Type("Some text");

            Assert.IsTrue(field.Contains("text"));
            Assert.AreEqual("Some text", field.Content());
        }
    }
}
