namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = "Welcome to SoftUni and have fun learning programming"
                .Split()
                .ToArray();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(words.Length);
               
                string currentWord = words[i];
                string randomWord = words[randomIndex];

                
                Console.WriteLine(words[randomIndex]);
            }
        }
    }
}