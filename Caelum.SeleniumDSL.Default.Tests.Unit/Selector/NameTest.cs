using Caelum.SeleniumDSL.Default.Selector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.SeleniumDSL.Default.Tests.Unit.Selector
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        public void ReturnsExpectedExpressionForFullName()
        {
            string expr = Name.Is("someName").GetExpression();

            Assert.AreEqual("@name='someName'", expr);
        }

        [TestMethod]
        public void ReturnsExpectedExpressionForPartialName()
        {
            string expr = Name.Contains("someName").GetExpression();
            Assert.AreEqual("contains(@name, 'someName')", expr, true);
        }

    }
}
