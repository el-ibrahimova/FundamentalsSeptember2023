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
                }
                else if (command == "Reverse")
                { 
                
                }

            }
        }
    }
}