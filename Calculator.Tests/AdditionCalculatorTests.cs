using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Calculator.UnitTests
{
    [TestClass]
    public class AdditionCalculatorTests
    {
        [TestMethod]
        public void CheckAdditionOperationPositive()
        {
            var logicMethod = new Calculator.CalculatorLogic();
            var addAction = logicMethod.DoOperation(2, 2, "+");
            Assert.AreEqual(4, addAction);
        }
        [TestMethod]
        public void CheckAdditionOperationNegative()
        {
            var logicMethod = new Calculator.CalculatorLogic();
            var addAction = logicMethod.DoOperation(2, 2, "+");
            Assert.AreNotEqual(5, addAction);
        }
        [TestMethod]
        public void CheckAdditionOperationMinusNumbersPositive()
        {
            var logicMethod = new Calculator.CalculatorLogic();
            var addAction = logicMethod.DoOperation(-2, -2, "+");
            Assert.AreEqual(-4, addAction);
        }
    }
}
