﻿#region

using Caelum.SeleniumDSL.Default.Tests.Integration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Integration.Caelum.SeleniumDSL
{
    [TestClass]
    public class ContentTagTest : IntegrationTest
    {
        [TestMethod]
        public void TestExists()
        {
            openIndex();
            Assert.IsTrue(browser.CurrentPage().Div("oneDiv").Exists());
        }

        [TestMethod]
        public void TestInnerHTML()
        {
            openIndex();
            Assert.AreEqual("Div content", browser.CurrentPage().Div("oneDiv").InnerHTML());
        }

        [TestMethod]
        public void TestContains()
        {
            openIndex();
            Assert.IsTrue(browser.CurrentPage().Div("oneDiv").Contains("content"));
        }
    }
}