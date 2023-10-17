using System.Net.NetworkInformation;

namespace _03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> address = Console.ReadLine().Split('@').ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            string input = command[0];
            int cellIndex = 0;
            int houseCounter = 0;

            while (input != "Love!")
            {
                int length = int.Parse(command[1]);

                if (input == "Jump")
                {
                    cellIndex += length;

                    if (cellIndex < 0 || cellIndex >= address.Count)
                    {
                        cellIndex = cellIndex % address.Count;
                    }
                    int newValue = int.Parse(address[cellIndex]);

                    if (newValue == 0)
                    {
                        Console.WriteLine($"Place {cellIndex} already had Valentine's day.");

                    }
                    newValue = newValue - 2;
                    address[cellIndex] = newValue.ToString();


                    if (newValue == 0)
                    {
                        Console.WriteLine($"Place {cellIndex} has Valentine's day.");
                        houseCounter++;
                    }

                }

                command = Console.ReadLine().Split().ToList();
                input = command[0];
            }
            Console.WriteLine($"Cupid's last position was {cellIndex}.");
            if (houseCounter == address.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {address.Count - houseCounter} places.");
            }
        }
    }
}