using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Dictionary<string, string> mirrorWords = new Dictionary<string, string>();

            string input = Console.ReadLine();

            string pattern = @"(@|#)(?<first>[A-Za-z]{3,}|[a-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                string matchWord = match.Groups[0].Value;
                words.Add(matchWord);

                string firstWord = match.Groups["first"].Value;
                string secondWord = match.Groups["second"].Value;

                bool isMirror = false;
                for (int i = 0; i <= firstWord.Length - 1; i++)
                {
                    if (firstWord.Length != secondWord.Length)
                    {
                        break;
                    }

                    if (firstWord[i] == secondWord[firstWord.Length - 1 - i])
                    {
                        if (i == firstWord.Length - 1)
                        {
                            isMirror = true;
                            mirrorWords.Add(firstWord, secondWord);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (words.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{words.Count} word pairs found!");
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.Write(string.Join(", ", mirrorWords.Select(w => $"{w.Key} <=> {w.Value}")));
            }
        }
    }
}