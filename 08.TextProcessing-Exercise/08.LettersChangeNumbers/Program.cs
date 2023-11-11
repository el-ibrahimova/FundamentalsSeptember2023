namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0;

            foreach (string str in strings)
            {
                // F 6666 G
                char letterBefore = str[0];  // F
                char letterAfter = str[str.Length - 1]; // G
                decimal number = decimal.Parse(str.Substring(1, str.Length - 2));  // 6666

                decimal position;   // C => 'C' - 'A' + 1 = 67 - 65 + 1 = 3
                decimal result = 0;


                if (char.IsUpper(letterBefore))
                {
                    position = letterBefore - 'A' + 1;
                    result = number / position;
                }
                else if (char.IsLower(letterBefore))
                {
                    position = letterBefore - 'a' + 1;
                    result = number * position;
                }

                if (char.IsUpper(letterAfter))
                {
                    position = letterAfter - 'A' + 1;
                    result -= position;
                }
                else if (char.IsLower(letterAfter))
                {
                    position = letterAfter - 'a' + 1;
                    result += position;
                }
                totalSum += result;
            }
            Console.WriteLine($"{totalSum:F2}");

        }
    }
}