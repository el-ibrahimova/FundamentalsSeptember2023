namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                bool isPalindromNumber = IsPalindrom(input);

                if (!IsPalindrom(input))
                {
                    isPalindromNumber = false;
                    Console.WriteLine("false");
                } 
                else if (IsPalindrom(input))
                {
                    isPalindromNumber = true;
                    Console.WriteLine("true");
                }
               
            }
        }

        static bool IsPalindrom(string symbol)
        {
            bool isPalindrom = true;
            for (int i = 0; i < symbol.Length; i++)
            {
                if (symbol[i] == symbol[symbol.Length - 1 - i])
                {
                    isPalindrom = true;
                    return true;
                }
                else
                {
                    isPalindrom = false;
                    return false;
                }
            }
            return true;
        }
    }
}