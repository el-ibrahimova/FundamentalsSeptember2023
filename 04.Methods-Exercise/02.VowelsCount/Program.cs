namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sum = SumOfVouels(text);
            Console.WriteLine(sum);

        }

        static int SumOfVouels(string text)
        {
            int vouels = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'o' || text[i] == 'u' || text[i] == 'e' || text[i] == 'i' ||
                    text[i] == 'A' || text[i] == 'O' || text[i] == 'U' || text[i] == 'E' || text[i] == 'I')
                {
                    vouels += 1;
                }
            }
            return vouels;
        }
    }
}