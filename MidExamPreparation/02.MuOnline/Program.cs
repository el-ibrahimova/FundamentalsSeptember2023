internal class Program
{
    private static void Main(string[] args)
    {
        List<string> dungeonRooms = Console.ReadLine()
             .Split("|", StringSplitOptions.RemoveEmptyEntries)
             .ToList();

        bool isFinished = false;
        bool isMaxBitcoin = false;

        int health = 100;
        int bitcoin = 0;
        int maxBitCoin = 0;

        for (int i = 0; i < dungeonRooms.Count; i++)
        {
            string room = dungeonRooms[i];
            string[] splitted = room.Split();

            string command = splitted[0];
            int value = int.Parse(splitted[1]);

            if (maxBitCoin > bitcoin)
            {
                maxBitCoin = bitcoin;
                isMaxBitcoin = true;

            }

            if (command == "potion")
            {
                if (health < 100)
                {
                    health += value;
                    if (health > 100)
                    {
                        value = health - 100;
                        health = 100;
                        
                    }
                }
                else
                {
                    health = 100;
                }
                Console.WriteLine($"You healed for {value} hp.");
                Console.WriteLine($"Current health: {health} hp.");

            }
            else if (command == "chest")
            {
                bitcoin += value;
                Console.WriteLine($"You found {value} bitcoins.");
            }
            else
            {
                health -= value;
                if (health > 0)
                {
                    Console.WriteLine($"You slayed {command}.");
                }
                else
                {
                    Console.WriteLine($"You died! Killed by {command}.");
                    if (true)
                    { isMaxBitcoin = true;
                        Console.WriteLine($"Best room: {i}");
                    }
                    
                    break;
                }
            }

            if (isFinished == true)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoin}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}