namespace _02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string random = Console.ReadLine();

            int firstIndex = (int)first;
            int secondIndex = (int)second;
            int sum = 0;


            foreach (char symbol in random)
            {
                if (symbol > firstIndex && symbol < secondIndex)
                {
                    sum += symbol;
                }
            }

            Console.WriteLine(sum);
        }
    }
}