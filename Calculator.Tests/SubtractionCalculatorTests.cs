using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Calculator.UnitTests
{
    [TestClass]
    public class SubtractionCalculatorTests
    {
        [TestMethod]
        public void CheckSubtractionOperationPositive()
        {
            var logicMethod = new Calculator.CalculatorLogic();
            var subtractionAction = logicMethod.DoOperation(2, 2, "-");
            Assert.AreEqual(0, subtractionAction);
        }
        [TestMethod]
        public void CheckSubtractionOperationNegative()
        {
            var logicMethod = new Calculator.CalculatorLogic();
            var subtractionAction = logicMethod.DoOperation(5, 2, "-");
            Assert.AreNotEqual(5, subtractionAction);
        }
        [TestMethod]
        public void CheckSubtractionOperationMinusNumbersPositive()
        {
            var logicMethod = new Calculator.CalculatorLogic();
            var subtractionAction = logicMethod.DoOperation(-2, -2, "-");
            Assert.AreEqual(0, subtractionAction);
        }
    }
}
