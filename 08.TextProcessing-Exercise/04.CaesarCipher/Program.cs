using System.Data.Common;
using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder cipherBuilder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char original = text[i];
                cipherBuilder.Append((char)(original+3)); // ако остане само original +3  резултата ще е число
            }
            Console.WriteLine(cipherBuilder);
        }
    }
}