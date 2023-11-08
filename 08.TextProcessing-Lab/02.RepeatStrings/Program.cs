namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string result = string.Empty;

            foreach (string word in words)
            {
                int length = word.Length; // hi -> 2

                for (int i = 0; i < length; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result);
        }
    }
}