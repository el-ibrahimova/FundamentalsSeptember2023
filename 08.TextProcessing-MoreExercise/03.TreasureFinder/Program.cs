using System.Text;

namespace _03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input;
            while ((input = Console.ReadLine()) != "find")
            {
				int keyCounter = 0;
				string decryptedMessage = string.Empty;
				
				for (int i = 0; i < input.Length; i++)
                {
                    decryptedMessage += (char)(input[i] - key[keyCounter]);
                    keyCounter++;

                    if (keyCounter == key.Length)
                    {
                        keyCounter = 0;
                    }
                }

				string treasure = Encrypt(decryptedMessage, '&', '&');
				string coordinates = Encrypt(decryptedMessage, '<', '>');

				Console.WriteLine($"Found {treasure} at {coordinates}");
			}
		}
		static string Encrypt(string decryptedMessage, char first, char second)
		{
			int firstIndex = decryptedMessage.IndexOf(first);
			int secondIndex = decryptedMessage.LastIndexOf(second);
			
            return decryptedMessage.Substring(firstIndex + 1, secondIndex - firstIndex - 1);
        }
    }
}