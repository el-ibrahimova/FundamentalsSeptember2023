using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> sequence = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        int movesCount = 0;
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            int[] indexes = input
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            int firstIndex = indexes[0];
            int secondIndex = indexes[1];
            movesCount++;

            // check players cheat
            if (CheckIndexes(sequence, firstIndex, secondIndex))
            {
                string newSymbol = $"-{movesCount}a";

                // new array with two symbols
                List<string> newElements = new List<string>() { newSymbol, newSymbol };

                int middleIndex = sequence.Count / 2;
                sequence.InsertRange(middleIndex, newElements);

                Console.WriteLine("Invalid input! Adding additional elements to the board");
            }          
            else
            {  // hit two matching elements
                if (sequence[firstIndex] == sequence[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequence[firstIndex]}!");
                    // трябва да изтрием индексите от дясно на ляво, за да не се разместят индексите
                    // търсим кой е по-големия индекс и трием първо него
                    if (firstIndex < secondIndex)
                    {
                        sequence.RemoveAt(firstIndex);
                        sequence.RemoveAt(secondIndex - 1);
                    }
                    else
                    {
                        sequence.RemoveAt(secondIndex);
                        sequence.RemoveAt(firstIndex - 1);
                    }
                }
                else if (sequence[firstIndex] != sequence[secondIndex])
                // hit two different elements
                {
                    Console.WriteLine("Try again!");
                }
            }

            // hit all matching elements
            if (sequence.Count ==0)
            {
                Console.WriteLine($"You have won in {movesCount} turns!");
                break;
            }
        }

        // receives "end" before hits all matching elements
        if (sequence.Count != 0)
        {
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", sequence));
        }

    }

    static bool CheckIndexes(List<string> sequence, int firstIndex, int secondIndex)
    {
        return firstIndex == secondIndex || (firstIndex < 0 || firstIndex >= sequence.Count) ||
                        (secondIndex < 0 || secondIndex >= sequence.Count);
    }
}