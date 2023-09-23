namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfliters = int.Parse(Console.ReadLine());
            int totalLiters = 255;
            

            for (int i = 1; i <= numberOfliters; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());

                if (currentLiters > totalLiters)
                {
                    Console.WriteLine("Insufficient capacity!");
                    
                }
                else
                {
                    totalLiters -= currentLiters;
                }
            }
            Console.WriteLine(255- totalLiters);
        }
    }
}