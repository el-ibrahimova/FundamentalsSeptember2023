﻿namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool isIdentical = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else if (arr1[i] == arr2[i])
                {
                    sum += arr2[i];
                    if (i == arr1.Length - 1)
                    { Console.WriteLine($"Arrays are identical. Sum: {sum}");}
                }
            }
        }
    }
}