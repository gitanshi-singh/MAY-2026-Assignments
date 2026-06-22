using System;
using System.Collections.Generic;
using System.Text;

namespace MAY_250526
{
    internal class Q1_remainder
    {
// Sum of 2D array and store the sum in third array
        public static void Run()
        {
            int dividend, divisor, quotient, remainder;

            Console.WriteLine("Enter dividend: ");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            quotient = dividend / divisor;
            remainder = dividend - (quotient * divisor);

            Console.WriteLine("Remainder= " + remainder);
        }
    }
}
