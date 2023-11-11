using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.Append(input[0]); // изписваме първата буква от резултата с input[0], защото иначе тя няма да се появи в resultBuilder

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1]) //  aaaaabbbsddddeeeeedssaa
                {
                    resultBuilder.Append(input[i]);

                }
            }
            Console.WriteLine(resultBuilder);
        }

    }
}
/* друг начин за решаване на задачата - с метод
 * 
   string input = Console.ReadLine();

 string result = ReplaceRepeatedCharacters(input);
 Console.WriteLine(result);
}

static string ReplaceRepeatedCharacters(string input)
{
 if (string.IsNullOrEmpty(input))
 {
     return input;
 }

 string result = input[0].ToString();

 for (int i = 1; i < input.Length; i++)
 {
     if (input[i] != input[i - 1])
     {
         result += input[i];
     }
 }

 return result;

  */
