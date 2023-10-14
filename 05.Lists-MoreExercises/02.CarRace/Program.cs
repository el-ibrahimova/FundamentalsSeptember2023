using System.Diagnostics.CodeAnalysis;

namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double timeLeft = 0;
            double timeRight = 0;
            int indexFinish = numbers.Count / 2;

                        
            for (int i = 0; i < indexFinish; i++)
            {
                if (numbers[i] == 0)
                {
                    timeLeft = timeLeft * 0.8;
                }
                else 
                {
                    timeLeft += numbers[i];
                }
            }


            for (int i = numbers.Count - 1; i > indexFinish; i--)
            {
                if (numbers[i] == 0)
                {
                    timeRight = timeRight * 0.8;
                }
                else
                {
                    timeRight += numbers[i];
                }
            }

            if (timeLeft < timeRight)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeft.ToString():f1}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeRight.ToString():f1}");
            }

        }
    }
}