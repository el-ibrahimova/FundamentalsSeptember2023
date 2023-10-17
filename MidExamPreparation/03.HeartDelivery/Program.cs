using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> address = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            int currentPossition = 0;

            while (input != "Love!")
            {
                List<string> inputArg = input
                    .Split()
                    .ToList();

                if (inputArg[0] == "Jump")
                {
                    currentPossition += int.Parse(inputArg[1]);
                }

                // ако позицията излезне от границите на листа от дясно
                if (currentPossition > address.Count - 1)
                {
                    currentPossition = 0;
                }

                if (address[currentPossition] == 0)
                {
                    Console.WriteLine($"Place {currentPossition} already had Valentine's day.");
                }
                else
                {
                    address[currentPossition] -= 2;

                    if (address[currentPossition] == 0)
                    {
                        Console.WriteLine($"Place {currentPossition} has Valentine's day.");
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currentPossition}.");

            int counter = address.Count(h => h > 0);

            if (address.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}