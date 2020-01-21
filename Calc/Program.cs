using System;
using ProgramTexts;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0; double num2 = 0;

            Console.WriteLine(ProgramText.Title);
            Console.WriteLine();
            Console.WriteLine(ProgramText.SelectNum1);
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ProgramText.SelectNum2);
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ProgramText.SelectMathAction);
            Console.WriteLine(ProgramText.Add);
            Console.WriteLine(ProgramText.Subtract);
            Console.WriteLine(ProgramText.Muliply);
            Console.WriteLine(ProgramText.Devide);
            Console.Write(ProgramText.SelectAction);
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    while (num2 == 0)
                    {
                        Console.WriteLine(ProgramText.NonZero);
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.WriteLine(ProgramText.CloseApp);
            Console.ReadKey();
        }
    }
}
