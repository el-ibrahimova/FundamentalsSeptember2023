namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = Console.ReadLine();

            string line;
            while ((line = Console.ReadLine()) != "Reveal")
            {
                string[] tokens = line.Split(":|:");

                string command = tokens[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(tokens[1]);
                    secretMessage = secretMessage.Insert(index, " ");
                    Console.WriteLine(secretMessage);
                }
                else if (command == "ChangeAll")
                {
                    string substring = tokens[1];
                    string replacement = tokens[2];

                    secretMessage = secretMessage.Replace(substring, replacement);
                    Console.WriteLine(secretMessage);
                }
                else if (command == "Reverse")
                {
                    string substring = tokens[1];
                    int substringIndex = secretMessage.IndexOf(substring);
                    // ако substring се съдържа във secretMessage, то ще ни върне като резултат индекса, на който се намира. Ако не - ще върне стойност -1
                    
                    if (substringIndex == -1) 
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    secretMessage = secretMessage.Remove(substringIndex, substring.Length);

                    string reversedSubstring = new string(substring.Reverse().ToArray());
                    //след Reverse метода ни се връща масив от char => пишем  new string, за да го превърнем в string


                    // reversedSubstring може да се запише и така:
                   // for (int i = substring.Length -(1); i >=0; i--)
                   // {
                   //     reversedSubstring += substring[i]; 
                   // }

                    secretMessage += reversedSubstring;
                    Console.WriteLine(secretMessage);
                }

            }
            Console.WriteLine($"You have a new text message: {secretMessage}");
        }
    }
}