using System.Text.RegularExpressions;

namespace Exam_02.EncryptingPassword
{
    /*
  3
  ##>00|no|NO|!!!?<###
  ##>123|yes|YES|!!!<##
  $$<111|noo|NOPE|<<>$$

     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"(.+)\>(?<numbers>\d{3})\|(?<letters>[a-z]{3})\|(?<LETTERS>[A-Z]{3})\|(?<symbols>[^\<\>]{3})\<\1";


                if (Regex.IsMatch(input, pattern))
                {
                    foreach (Match match in Regex.Matches(input, pattern))
                    {
                        string valid = match.Groups[0].Value;
                        string encrypt = match.Groups["numbers"].Value + match.Groups["letters"].Value + match.Groups["LETTERS"].Value + match.Groups["symbols"].Value;
                        Console.WriteLine($"Password: {encrypt}");
                    }
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}