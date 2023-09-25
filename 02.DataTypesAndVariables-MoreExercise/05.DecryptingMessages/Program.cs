using System.ComponentModel.Design;

namespace _05.DecryptingMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            int numberOfChar = int.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 1; i <= numberOfChar; i++)
            {
                string input = Console.ReadLine();
                int currentCharValue = input[0]; // първата буква на char е със стойност 0, а в случая е само една буква
                int messageCharValue = key + currentCharValue;
                char currentChar = (char)messageCharValue;
                message += currentChar;
            }
            Console.WriteLine(message);

        }
    }
}