namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--; // премахнали сме елемент и с това i-- компенсираме в numbers.Count
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}