using System.Runtime.CompilerServices;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int iterations = Math.Max(first.Count, second.Count); // метод, с който намираме кой лист има повече елементи и взимаме техния брой
            for (int i = 0; i < iterations; i++)
            {
                if (i < first.Count)
                {
                    result.Add(first[i]);
                }
                if (i < second.Count)
                {
                    result.Add(second[i]);
                }

            }
            Console.Write(string.Join(" ", result));
        }
    }
}