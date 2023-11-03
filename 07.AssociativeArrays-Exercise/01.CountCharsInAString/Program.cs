namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charOccurances = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (character == ' ')
                {
                    continue;
                }

                if (!charOccurances.ContainsKey(character))
                {
                    charOccurances.Add(character, 0);
                }
                charOccurances[character]++;

            }

            foreach (var occurance in charOccurances)
            {
                char symbol = occurance.Key;
                int count = occurance.Value;

                Console.WriteLine($"{symbol} -> {count}");
            }
        }
    }
}