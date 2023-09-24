namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double totalSpent = 0;

            while (game != "Game Time")
            {
                double gamePrice = 0;
                if (game == "RoverWatch Origins Edition") { gamePrice = 39.99; }
                else if (game == "OutFall 4") { gamePrice = 39.99; }
                else if (game == "CS: OG") { gamePrice = 15.99; }
                else if (game == "Zplinter Zell") { gamePrice = 19.99; }
                else if (game == "Honored 2") { gamePrice = 59.99; }
                else if (game == "RoverWatch") { gamePrice = 29.99; }
                else
                {
                    Console.WriteLine("Not Found");

                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!"); break;
                }
                else if (gamePrice > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= gamePrice;
                    totalSpent += gamePrice;
                }

                game = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");

        }
    }
}