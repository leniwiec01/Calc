using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;


namespace Calculator.UnitTests
{
    [TestClass]
    public class AddingCalculatorTests
    {
        [TestMethod]
        public void PositiveAddAction()
        {
            var calc = new Calculator.CalculatorLogic();
            var sum = calc.DoOperation(2, 2, "+");
            Assert.AreEqual(4, sum);
        }
    }
}
