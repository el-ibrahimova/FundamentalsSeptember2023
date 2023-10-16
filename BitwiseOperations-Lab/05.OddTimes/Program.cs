namespace _05.OddTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int result = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                result = result ^ numbers[i];
            }
            Console.WriteLine(result);

        }
    }
}