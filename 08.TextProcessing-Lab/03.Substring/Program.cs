namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string words = Console.ReadLine();

            while (words.Contains(wordToRemove))
            {
                int index = words.IndexOf(wordToRemove);

               words = words.Remove(index, wordToRemove.Length); // презаписваме думата
            }
            Console.WriteLine(words);

        }
    }
}