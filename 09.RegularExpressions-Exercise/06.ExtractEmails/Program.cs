using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string pattern = @"(?<user>[^\.\-_][a-z0-9]+(?:\.*\-*_*)[a-z0-9]+)@(?<host>[a-z]+\-*[a-z]+\.([a-z]+\.)*[a-z]+)";

           MatchCollection collection = Regex.Matches(input, pattern);
            
            foreach (var address in collection)
            {

                Console.WriteLine(address);
            }

            

        }
    }
}