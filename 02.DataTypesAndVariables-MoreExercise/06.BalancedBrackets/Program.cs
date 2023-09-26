using System;

namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int openBracelet = 0;
            int closeBracelet = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
               
                 openBracelet = input.IndexOf('(');
                 closeBracelet = input.IndexOf(')');

                if (openBracelet == '(')
                {
                    openBracelet++;
                }
                else if (closeBracelet == ')')
                { 
                    closeBracelet++;
                }
            }

            if (openBracelet == closeBracelet)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}