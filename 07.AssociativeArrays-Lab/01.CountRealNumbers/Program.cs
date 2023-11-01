namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            SortedDictionary<int, int> sortedNumbers = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!sortedNumbers.ContainsKey(number))
                {
                    sortedNumbers.Add(number, 1); // ако го няма в списъка sorted, го добавяме
                }
                else
                {
                    sortedNumbers[number] += 1; // ако числото вече е в списъка, увеличаваме неговия брой
                }
            }

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}