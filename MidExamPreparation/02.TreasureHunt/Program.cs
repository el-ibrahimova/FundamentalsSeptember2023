using System.ComponentModel.Design;

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

                }
                else if (input == "Drop")
                {

                }
                else if (input == "Steal")
                { 
                
                }

                commands = Console.ReadLine().Split().ToList();
                input = commands[0];
            }
        }
    }
}