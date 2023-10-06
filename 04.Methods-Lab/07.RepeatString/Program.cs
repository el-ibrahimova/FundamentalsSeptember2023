namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatString(text, n);
                Console.WriteLine(result);
            
        }

        static string RepeatString(string text, int repeat)
        {
            string newText = "";
            for (int i = 0; i < repeat; i++)
            {
                newText += text;
            }
            return newText;
        }
    }
}