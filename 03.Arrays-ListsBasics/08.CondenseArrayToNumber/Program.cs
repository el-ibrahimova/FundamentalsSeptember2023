using System.Globalization;

namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                while (numbers[i] > 1)
                {
                    int[] condensed = { numbers.Length };
                    condensed[i] = numbers[i] + numbers[i + 1];
                    numbers[i] = condensed[i];
                }
                Console.WriteLine(numbers[i]);
            }           

        }
    }
}