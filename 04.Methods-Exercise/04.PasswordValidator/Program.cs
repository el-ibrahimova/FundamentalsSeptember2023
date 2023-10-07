using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!CharactersRange(password))
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            if (!IsLetterOrDigit(password))
            {
                isValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!AtLeast2Digits(password))
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid==true)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool AtLeast2Digits(string password)
        {
            return password.Count(char.IsDigit) >=2;
        }

        static bool IsLetterOrDigit(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }

        static bool CharactersRange(string password)
        {
            return password.Length is >= 6 and <= 10;
        }
    }
}