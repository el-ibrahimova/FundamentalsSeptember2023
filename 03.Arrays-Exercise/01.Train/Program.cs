using System.Diagnostics.CodeAnalysis;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;
                

            for (int i = 0; i < n; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                wagons[i] = passengers;
                sum += wagons[i];
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sum);
        }
    }
}