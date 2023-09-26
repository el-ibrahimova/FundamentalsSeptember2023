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

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                
                if (input == "(")
                {
                    openBracelet++;
                }
                else if (input == ")")
                { 
                    closeBracelet++;
                    if (openBracelet - closeBracelet != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
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