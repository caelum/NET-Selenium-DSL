using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Selenium;
using Caelum.SeleniumDSL;

namespace Unit.Caelum.SeleniumDSL
{
    [TestClass]
    public class FieldTest : UnitTest
    {
        [TestMethod]
        public void TestBlur()
        {
            selenium.Setup(o => o.FireEvent("", "blur"));

            new Field(selenium.Object, null, "").Blur();
        }

        [TestMethod]
        public void TestChange()
        {
            selenium.Setup(o => o.FireEvent("", "change"));

            new Field(selenium.Object, null, "").Change();
        }

        [TestMethod]
        public void TestContains()
        {
            selenium.Setup(o => o.GetValue("someId"))
                .Returns("Some text");
            
            Field field = new Field(selenium.Object, null, "someId");

            Assert.IsTrue(field.Contains("text"));
        }

        [TestMethod]
        public void TestContent()
        {
            selenium.Setup(o => o.GetValue("someId"))
                .Returns("Some text");

            Field field = new Field(selenium.Object, null, "someId");

            Assert.AreEqual("Some text", field.Content());
        }

        [TestMethod]
        public void TestType()
        {
            selenium.Setup(o => o.Type("someId", "Some text"));

            Field field = new Field(selenium.Object, null, "someId");

            field.Type("Some text");
        }

    }
}
