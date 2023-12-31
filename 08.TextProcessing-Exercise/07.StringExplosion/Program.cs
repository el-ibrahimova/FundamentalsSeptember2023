﻿using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = ProcessExplosions(input);
            Console.WriteLine(result);
        }

        private static string ProcessExplosions(string input)
        {
            StringBuilder resultBuilder = new StringBuilder();

            int strength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    resultBuilder.Append(input[i]);
                }
                else if (strength == 0)
                {
                    resultBuilder.Append(input[i]);
                }
                else
                {
                    strength--; // пропускаме елемента от input, (който е изгърмял, в зависимост от силата на взрива) и намаляваме силата с 1
                }
            }

            return resultBuilder.ToString(); // връща клас, а на нас ни трябва string => To.String()
        }
    }
}