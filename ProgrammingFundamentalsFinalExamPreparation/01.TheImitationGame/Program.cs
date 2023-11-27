using System.Text;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string newMessage = "";

            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] arguments = input.Split("|");
                string command = arguments[0];

                if (command == "Move")
                {
                    StringBuilder message = new StringBuilder();
                    int numberOfLetters = int.Parse(arguments[1]);
                    string lettersToAdd = encryptedMessage.Substring(0, numberOfLetters);
                    string leftLetters = encryptedMessage.Substring(numberOfLetters);
                    message = message.Append(leftLetters);
                    newMessage = message.Append(lettersToAdd).ToString();
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(arguments[1]);
                    string value = arguments[2];
                    newMessage = encryptedMessage.Insert(index, value);
                }
                else // ChangeAll
                {
                    string substring = arguments[1];
                    string replacement = arguments[2];
                    newMessage = encryptedMessage.Replace(substring, replacement);
                }
                encryptedMessage = newMessage;            
            }
            Console.WriteLine($"The decrypted message is: {newMessage}");
        }
    }
}