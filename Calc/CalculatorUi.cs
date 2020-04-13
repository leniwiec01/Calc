using System;
using ProgramTexts;

namespace Calculator
{
    public class CalculatorUi
    {
        public static void Main(string[] args)
        {

            bool endApp = false;
            Console.WriteLine(ProgramText.Title);
            Console.WriteLine("-------------------------------------\n");
            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine(ProgramText.SelectNum1);
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write(ProgramText.IncorrectValue);
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine(ProgramText.SelectNum2);
                numInput1 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput1, out cleanNum2))
                {
                    Console.Write(ProgramText.IncorrectValue);
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine(ProgramText.SelectMathAction);
                Console.WriteLine(ProgramText.Add);
                Console.WriteLine(ProgramText.Subtract);
                Console.WriteLine(ProgramText.Muliply);
                Console.WriteLine(ProgramText.Devide);
                Console.Write(ProgramText.SelectAction);

                string op = Console.ReadLine();

                try
                {
                    var logic = new Calculator.CalculatorLogic();
                    result = logic.DoOperation(cleanNum1, cleanNum2, op);
                    //result = new CalculatorLogic.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine(ProgramText.ErrorWarning);
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(ProgramText.ErrorMessage + e.Message);
                }
                Console.WriteLine("------------------------\n");
                Console.WriteLine(ProgramText.ExitMessage);
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");
            }
            return;
        }
    }
}
