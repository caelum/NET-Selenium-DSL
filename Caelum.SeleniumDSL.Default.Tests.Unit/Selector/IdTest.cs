using Caelum.SeleniumDSL.Default.Selector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit.Selector
{
    [TestClass]
    public class IdTest
    {
        [TestMethod]
        public void ReturnExpectedExpressionForFullId()
        {
            string expression = Id.Is("someId").GetExpression();

            Assert.AreEqual("[@id='someId']", expression);
        }

        [TestMethod]
        public void ReturnExpectedExpressionForPartialId()
        {
            string expression = Id.Contains("someId").GetExpression();

            Assert.AreEqual("[contains(@id, 'someId')]", expression);
        }
    }
}
