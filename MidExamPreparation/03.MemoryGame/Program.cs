using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().
            Split(" ", StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).
            ToList();

        List<string> input = Console.ReadLine().Split().ToList();
        string index = input[0];
        int count = 0;

        while (index != "end")
        {
            int firstIndex = int.Parse(input[0]);
            int secondIndex = int.Parse(input[1]);
            count++;


            if (CheckIndexes(numbers, firstIndex, secondIndex))
            {
                int middleIndex = numbers.Count / 2;
                string firstIndexElement = $"-{count}a";
                int secondIndexElement = int.Parse(firstIndexElement);
                numbers.Insert(middleIndex+1, secondIndexElement);
                numbers.Insert(middleIndex+2, secondIndexElement);

                Console.WriteLine("Invalid input! Adding additional elements to the board");
            }
            input = Console.ReadLine().Split().ToList();
            index = input[0];
        }
    }

 static bool CheckIndexes(List<int> numbers, int firstIndex, int secondIndex)
    {
        return firstIndex == secondIndex || (firstIndex < 0 || firstIndex >= numbers.Count) ||
                        (secondIndex < 0 || secondIndex >= numbers.Count);
    }
}