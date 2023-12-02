using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Santa_sSecretHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> childrens = new List<string>();

            int key = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder message = new StringBuilder();
                foreach (char ch in input)
                {
                    message.Append((char)(ch - key));
                }
                
                string decodedMessage = message.ToString();
                string pattern = @"@(?<name>[A-Z][a-z]+)[^@\-\!:>]*?!(?<behavior>G|N)!";

                foreach (Match match in Regex.Matches(decodedMessage, pattern))
                {
                    string name = match.Groups["name"].Value;
                    string behavior = match.Groups["behavior"].Value;

                    if (behavior == "G")
                    { 
                    childrens.Add(name);
                    }
                }
            }
            Console.WriteLine(string.Join("\n", childrens));
        }
    }
}