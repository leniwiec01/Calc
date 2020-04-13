using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Calculator.UnitTests
{
    [TestClass]
    public class AddingCalculatorTests
    {
        [TestMethod]
        public void PositiveAddAction()
        {
            var logicMethod = new Calculator.CalculatorLogic();
            var addAction = logicMethod.DoOperation(2, 2, "+");
            Assert.AreEqual(4, addAction);
        }
    }
}
