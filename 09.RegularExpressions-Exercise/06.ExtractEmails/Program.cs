using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

              string pattern = @"[^\.\-_]\b(?![\._\-])[A-Za-z0-9]+[\.\-_]*[A-Za-z0-9]+@[^\.\-](?:[A-Za-z\.\-]+\.)+[A-Za-z]+";

           //  @"[^\.\-_]\b(?![\._\-]) [A-Za-z0-9]+  [\.\-_]*[A-Za-z0-9]+ @  [^\.\-](?:[A-Za-z\.\-]+\.)+ [A-Za-z]+";


            MatchCollection collection = Regex.Matches(input, pattern);
            
            
            foreach (var address in collection)
            {
                Console.WriteLine(address);
            }
        }
    }
}