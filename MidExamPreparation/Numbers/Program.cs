﻿namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

           
            double average = numbers.Average();

            List<int> greatherThanAverage = new List <int> ();
             int count = 0;
          
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    greatherThanAverage.Add(numbers[i]);
                    count++;
                }
            }
            if (count == 0)
                {
                    Console.WriteLine("No");
                return;
                }

            List<int> max5Numbers = new List <int>(5);
            for (int i = 0; i < greatherThanAverage.Count; i++)
            {
                int max = greatherThanAverage.Max();
                max5Numbers.Add(max);
                greatherThanAverage.Remove(max);
                i--;        
            }

            if (max5Numbers.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{max5Numbers[i]} ");
                }
            }
            else if (max5Numbers.Count < 5)
            {
                Console.WriteLine(string.Join(" ", max5Numbers));
            }
            


        }
    }
}