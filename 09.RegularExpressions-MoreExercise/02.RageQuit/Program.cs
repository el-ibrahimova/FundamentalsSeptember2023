using System.Text.RegularExpressions;
using System.Text;

/*
a3

aSd2&5s@1
*/

namespace _02.RageQuit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> counts = new List<int>();
            List<string> words = new List<string>();

            string input = Console.ReadLine();
            input = input.ToUpper();

            string pattern = @"[\d]+";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                int count = int.Parse(match.Groups[0].Value);
                counts.Add(count);
            }

            string[] symbolArr = input.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < symbolArr.Length; i++)
            {
                string first = symbolArr[i];
                words.Add(first);
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Count; i++)
            {
                string resultWord = "";
                for (int j = 0; j < counts[i]; j++)
                {
                    resultWord += words[i];
                }
                result.Append(resultWord);
            }
            string finish = result.ToString();

            List<char> unique = new List<char>();
            foreach (char ch in finish)
            {
                if (!unique.Contains(ch))
                {
                    unique.Add(ch);
                }
            }
            Console.WriteLine($"Unique symbols used: {unique.Count}");
            Console.WriteLine(finish);
        }
    }
}
    