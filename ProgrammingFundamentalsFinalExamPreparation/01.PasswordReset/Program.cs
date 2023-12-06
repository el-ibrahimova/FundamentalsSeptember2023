using System.Text;

namespace _01.PasswordReset
{
/*
 Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr 
TakeOdd
Cut 15 3
Substitute :: -
Substitute | ^
Done
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawPassword = Console.ReadLine();
            string newPassword = "";

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split();
                string command = commands[0];

                if (command == "TakeOdd")
                {
                    StringBuilder password = new StringBuilder();

                    for (int i = 0; i < rawPassword.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            password.Append(rawPassword[i]);
                        }
                    }
                    newPassword = password.ToString();
                    Console.WriteLine(newPassword);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);

                    string cut = rawPassword.Substring(index, length);
                    int indexCut = rawPassword.IndexOf(cut);
                    newPassword = rawPassword.Remove(indexCut, cut.Length);
                    Console.WriteLine(newPassword);
                }
                else if (command == "Substitute")
                {
                    string textSubstring = commands[1];
                    string substitute = commands[2];

                    if (rawPassword.Contains(textSubstring))
                    {
                        newPassword = rawPassword.Replace(textSubstring, substitute);
                        Console.WriteLine(newPassword);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                rawPassword = newPassword;
            }

            Console.WriteLine($"Your password is: {newPassword}");
        }
    }
}