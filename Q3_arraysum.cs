using System;
using System.Collections.Generic;
using System.Text;

namespace MAY_250526
{
    internal class Q3_arraysum
    {
// Sum of 2D array and store the sum in third array
        public static void Run()
        {
            int[,] A = new int[2, 2];
            int[,] B = new int[2, 2];
            int[,] C = new int[2, 2];

            Console.WriteLine("Enter elements of first array: ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("A[" + i + "," + j + "]=");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of second array: ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("B[" + i + "," + j + "]=");
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            Console.WriteLine("\nSum of the arrays: ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(C[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
