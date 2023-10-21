namespace _03.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();

            int maxHealth = int.Parse(Console.ReadLine());
            bool isSunken = false;
            bool isWin = false;

            while (true)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();

                if (command[0] == "Retire")
                {
                    break;
                }
                else if (command[0] == "Fire")
                {
                    int index = int.Parse(command[1]);
                    int damage = int.Parse(command[2]);

                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] = warShip[index] - damage;
                        if (warShip[index] <= 0)
                        {
                            isWin = true;
                        }
                    }
                    if (isWin == true)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        break;
                    }
                }
                else if (command[0] == "Defend")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int damage = int.Parse(command[3]);

                    if ((startIndex >= 0 && startIndex < pirateShip.Count) && (endIndex >= 0 && endIndex < pirateShip.Count))
                    {

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] = pirateShip[i] - damage;

                            if (pirateShip[i] <= 0)
                            {
                                isSunken = true;
                            }
                        }
                    }
                    if (isSunken == true)
                    {
                        Console.WriteLine("You lost! The pirate ship has sunken.");
                        break;
                    }
                }
                else if (command[0] == "Repair")
                {
                    int index = int.Parse(command[1]);
                    int health = int.Parse(command[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        pirateShip[index] = pirateShip[index] + health;
                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                else if (command[0] == "Status")
                {
                    int count = 0;

                    double needToRepair = maxHealth * 0.2;

                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < needToRepair)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
            }

            if (isWin!=true && isSunken!=true)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warShip.Sum()}");
            }
        }
    }
}