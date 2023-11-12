using System.Text;

namespace _04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string[] currentWord = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string letter in currentWord)
                {
                    Console.Write(GetLetter(letter));
                }

                Console.Write(' ');
            }
        }

        static char GetLetter(string morseCodeLetter)
        {
            SortedDictionary<string, char> morseCode = new SortedDictionary<string, char>()
            {
                {".-", 'A'},
                {"-...", 'B'},
                {"-.-.", 'C'},
                {"-..", 'D'},
                {".", 'E'},
                {"..-.", 'F'},
                {"--.", 'G'},
                {"....", 'H'},
                {"..", 'I'},
                {".---", 'J'},
                {"-.-", 'K'},
                {".-..", 'L'},
                {"--", 'M'},
                {"-.", 'N'},
                {"---", 'O'},
                {".--.", 'P'},
                {"--.-", 'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-", 'T'},
                {"..-", 'U'},
                {"...-", 'V'},
                {".--", 'W'},
                {"-..-", 'X'},
                {"-.--", 'Y'},
                {"--..", 'Z'}
            };
            return morseCode[morseCodeLetter];
        }
    }
}
