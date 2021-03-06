﻿using System;

namespace ProgramTexts
{
    public class ProgramText
    {
        public static string Title => "Simple Calculator App\r";
        public static string SelectNum1 => "Select 1st number\r";
        public static string SelectNum2 => "Select 2nd number\r";
        public static string SelectMathAction => "Select math operation\r";
        public static string SelectAction => "Your option? ";
        public static string Add => "\t+ - Add";
        public static string Subtract => "\t- - Subtract";
        public static string Muliply => "\t* - Multiply";
        public static string Devide => "\t/ - Divide";
        public static string CloseApp => "Press any key to close the Calculator console app...";
        public static string NonZero => "Enter a non-zero divisor: ";
        public static string ResultText => "Your result: ";
        public static string IncorrectValue => "This is not valid input. Please enter an integer value: ";
        public static string ErrorWarning => "This operation will result in a mathematical error.\n";
        public static string ErrorMessage => "Oh no! An exception occurred trying to do the math.\n - Details: ";
        public static string ExitMessage => "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";
    }
}
