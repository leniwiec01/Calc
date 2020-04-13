using System;


namespace Calculator
{
    public class CalculatorLogic
    {
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch(op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
