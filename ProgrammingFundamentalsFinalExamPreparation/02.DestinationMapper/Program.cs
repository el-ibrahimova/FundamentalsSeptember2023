using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
/*
=Hawai=/Cyprus/=Invalid/invalid==i5valid=/I5valid/=i=
*/
        static void Main(string[] args)
        {  
            List<string> destinations = new List<string>();
            string text = Console.ReadLine();

            string pattern = @"(=|\/)(?<destination>[A-Z][A-Za-z]{2,})\1";

            foreach (Match match in Regex.Matches(text, pattern))
            {
                string destination = match.Groups["destination"].Value;
                destinations.Add(destination);
            }

            int points = 0;
            foreach (var dest in destinations)
            {
                points += dest.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}