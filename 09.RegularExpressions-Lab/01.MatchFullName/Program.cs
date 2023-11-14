using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);

            Console.WriteLine(string.Join(" ", matchCollection));


            // може да се реши и така
            /*
              string input = Console.ReadLine();
              string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
              MatchCollection matchCollection = Regex.Matches(input, pattern);
              Console.WriteLine(string.Join(" ", matchCollection));
           */

        }
    }
}