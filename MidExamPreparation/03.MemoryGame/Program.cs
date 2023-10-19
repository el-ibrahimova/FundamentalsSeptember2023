using System;
using System.Collections.Generic;

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
                .Split()
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
            // two matching elements
            else
            {
                if (sequence[firstIndex] == sequence[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - ${sequence[firstIndex]}!");

                    if (secondIndex > firstIndex)
                    {
                        sequence.RemoveAt(secondIndex);
                        sequence.RemoveAt(firstIndex);
                    }
                    else
                    {
                        sequence.RemoveAt(firstIndex);
                        sequence.RemoveAt(secondIndex);
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }


            if (movesCount == sequence.Count / 2)
            {
                Console.WriteLine($"You have won in {movesCount} turns!");
                break;
            }
        }


        Console.WriteLine("Sorry you lose :(");
        Console.WriteLine(string.Join(" ", sequence));

    }

    static bool CheckIndexes(List<string> sequence, int firstIndex, int secondIndex)
    {
        return firstIndex == secondIndex || (firstIndex < 0 || firstIndex >= sequence.Count) ||
                        (secondIndex < 0 || secondIndex >= sequence.Count);
    }
}