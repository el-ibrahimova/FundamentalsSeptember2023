using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            MatchCollection mathCollection = Regex.Matches(input, pattern);

            foreach (Match match in mathCollection)
            {
                var groups = match.Groups;

                Console.WriteLine($"Day: {groups["day"]}, Month: {groups["month"]}, Year: {groups["year"]}");
            }
        }
    }
}