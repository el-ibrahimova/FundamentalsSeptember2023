﻿namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
                       
            int result = Sum(input[0], input[1]);
            Console.WriteLine(result);
        }

        static int Sum(string first, string second)
        {
            int sum = 0;

            int length = Math.Max(first.Length, second.Length); //връща стойността на по-дългия стринг

            for (int i = 0; i < length; i++)
            {
                if (i < first.Length && i < second.Length)
                {

                    sum += first[i] * second[i];
                }
                else if (i < first.Length)
                {
                    sum += first[i];
                }
                else if (i < second.Length)
                {
                    sum += second[i];
                }
            }
            return sum;
        }
    }
}