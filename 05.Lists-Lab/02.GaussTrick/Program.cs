using System.Security.Cryptography.X509Certificates;

namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count/2; i++)
            {
                int first = numbers[i];
                int last = numbers[numbers.Count - i - 1];
                result.Add(first + last);
            }

            if (numbers.Count % 2 == 1) // ако елементите в листа са нечетен брой, то този в средата не се отразява,
                                        // правим тази проверка и го вписваме отделно в новия лист result
            {
                int middleIndex = numbers.Count / 2;
                result.Add(numbers[middleIndex]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}