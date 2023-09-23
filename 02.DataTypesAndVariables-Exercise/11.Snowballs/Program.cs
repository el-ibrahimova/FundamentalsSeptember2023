using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger highestSnowball = 0;
            double bestSnow = 0, bestTime = 0, bestQuality = 0;


            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snow / time), quality);

                if (value > highestSnowball)
                {
                    highestSnowball = value;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {highestSnowball} ({bestQuality})");
        }
    }
}