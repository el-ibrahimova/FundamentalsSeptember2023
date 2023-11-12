using System.Diagnostics;

namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                int nameStartIndex = (input.IndexOf('@')) + 1;
                int nameEndIndex = input.IndexOf('|');
                int nameLength = nameEndIndex - nameStartIndex;

                string name = input.Substring(nameStartIndex, nameLength);

                int ageStartIndex = (input.IndexOf('#')) + 1;
                int ageEndIndex = input.IndexOf('*');
                int ageLength = ageEndIndex - ageStartIndex;

                string age = input.Substring(ageStartIndex, ageLength);


                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}