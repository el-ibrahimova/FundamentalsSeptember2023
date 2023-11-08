namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] reversedWord = input.Reverse().ToArray();
                Console.WriteLine($"{input} = {string.Join("", reversedWord)}");
                input = Console.ReadLine();
            }
        }
    }
}