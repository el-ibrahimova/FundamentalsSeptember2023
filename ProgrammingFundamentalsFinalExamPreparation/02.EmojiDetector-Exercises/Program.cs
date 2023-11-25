using System.Text.RegularExpressions;

namespace _02.EmojiDetector_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string coolThresholdPattern = @"\d";
            string emojiPattern = @"(\*{2}|\:{2})(?<Emoji>[A-Z][a-z]{2,})\1";            

            List<string> coolEmojies = new List<string>();

            ulong coolThreshold = 1; // от 1 защото ще има умножение

            foreach (Match match in Regex.Matches(input, coolThresholdPattern))
            {
                coolThreshold *= ulong.Parse(match.Value);
            }

            MatchCollection matches = Regex.Matches(input, emojiPattern);
            foreach (Match match in matches)
            {
                string emojiStr = match.Groups["Emoji"].Value;
                ulong totalEmojiSum = 0;
              
                foreach (char character in emojiStr)
                {
                    totalEmojiSum += character;
                }

                if (totalEmojiSum >= coolThreshold)
                {
                    coolEmojies.Add(match.Value); 
                    //=> По условие: не ни е нужно само емоджито (Smiley), а цялата група 0 на регекса (::Smiley::), затова изписваме match.Value, а не emojiStr
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");


            foreach (string emoji in coolEmojies)
            {
                Console.WriteLine(emoji);
            }
            
            // може да се запише и така:
           // coolEmojies.ForEach(emoji => Console.WriteLine(emoji));
        }
    }
}