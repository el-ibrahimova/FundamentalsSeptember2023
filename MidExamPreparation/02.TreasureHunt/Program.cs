using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace _02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> commands = Console.ReadLine().Split().ToList();

            string input = commands[0];
            while (input != "Yohoho!")
            {

                if (input == "Loot")
                {
                    for (int i = 1; i < commands.Count; i++)
                    {
                        string items = commands[i];

                        if (!treasureChest.Contains(items))
                        {
                            treasureChest.Insert(0, items);
                        }
                    }
                }
                else if (input == "Drop")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < treasureChest.Count)
                    {
                        string newPosition = treasureChest[index];
                        treasureChest.RemoveAt(index);
                        treasureChest.Add(newPosition);
                    }
                }
                else if (input == "Steal")
                {
                    List<string> stolenItems = new List<string>();
                    int count = int.Parse(commands[1]);
                    count = Math.Min(treasureChest.Count, count);

                    for (int i = treasureChest.Count - count; i < treasureChest.Count; i++)
                    {
                        stolenItems.Add(treasureChest[i]);
                    }
                    Console.WriteLine(string.Join(", ", stolenItems));

                    treasureChest.RemoveRange(treasureChest.Count - count, count);

                }

                    commands = Console.ReadLine().Split().ToList();
                    input = commands[0];
                }

                double average = 0;
                for (int i = 0; i < treasureChest.Count; i++)
                {
                    average += treasureChest[i].Length;
                }

                if (average == 0)
                {
                    Console.WriteLine("Failed treasure hunt.");
                }
                else
                {
                    double averageGain = average / treasureChest.Count;
                    Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
                }


            }
        }
    }
