﻿namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string result = string.Empty;

            foreach (string word in words)
            {
                int repeatTimes = word.Length; // hi -> 2

                for (int i = 0; i < repeatTimes; i++) //2
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}