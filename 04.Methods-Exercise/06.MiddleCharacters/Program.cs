namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MiddleCharacters(text);
        }

        static void MiddleCharacters(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text.Length % 2 == 0)
                {
                    char symbol1 = text[text.Length / 2 - 1];
                    char symbol2 = text[text.Length / 2];
                    Console.WriteLine($"{symbol1}{symbol2}");
                    break;
                }
                else
                {
                    char symbol = text[text.Length / 2];
                    Console.WriteLine(symbol);
                    break;
                }
            }
        }
    }
}