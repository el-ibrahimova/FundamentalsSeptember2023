﻿namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            PrintTopPart(n);

            PrintBottomPart(n);
        }

        static void PrintBottomPart(int n)
        {
            for (int row = n - 1; row >= 1; row--)
            {
                PrintRow(row);
            }
        }
        static void PrintTopPart(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintRow(row);
            }
        }

        static void PrintRow(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col+" ");
            }

            Console.WriteLine();
        }
    }
}