namespace CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string input;
            int wonCount = 0;
            bool isLost = false;

            while ((input = Console.ReadLine()) != "End of battle")
            {
                int distanceToReachEnemy = int.Parse(input);


                if (initialEnergy < distanceToReachEnemy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonCount} won battles and {initialEnergy} energy");
                    return;
                }
                
                initialEnergy = initialEnergy - distanceToReachEnemy;
                wonCount++;
                if (wonCount % 3 == 0)
                {
                    initialEnergy += wonCount;
                }

            }

                Console.WriteLine($"Won battles: {wonCount}. Energy left: {initialEnergy}");
            
        }
    }
}