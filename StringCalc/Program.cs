using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("StringCalcTest")]

namespace StringCalculator
 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
    public class Calculator
    {

        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;
            int num1 = int.Parse(numbers);
            return num1;
        }
    }
}
