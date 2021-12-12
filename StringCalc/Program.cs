using System;
using System.Collections.Generic;
using System.Linq;
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

            if (int.Parse(numbers) > 999)
            {
                return 0;
            }

            if (!string.IsNullOrEmpty(numbers)) {


                return numbers.Split(',', '/').Sum(int.Parse);
            }
            
         
            return numbers.Split(',','/').Sum(int.Parse);
        }
      
    }
}
