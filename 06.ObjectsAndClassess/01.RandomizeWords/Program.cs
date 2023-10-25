namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(words.Length);
               
                string currentWord = words[i];
                string randomWord = words[randomIndex];

                words[i] = randomWord;
                words[randomIndex] = currentWord;

            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}