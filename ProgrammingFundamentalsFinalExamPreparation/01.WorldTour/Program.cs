using System;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace _01.WorldTour
{
/*
Hawai::Cyprys-Greece
Add Stop:7:Rome
Remove Stop:11:16
Switch:Hawai:Bulgaria
Travel
*/
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            string commands;
            while ((commands = Console.ReadLine()) != "Travel")
            {
                string[] command = commands.Split(":");
                string operation = command[0];

                if (operation == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string text = command[2];

                    if (index >= 0 && index <= input.Length)
                    {
                        input = input.Insert(index, text);
                    }
                    Console.WriteLine(input);
                }
                else if (operation == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && startIndex <= input.Length-1 
                        && endIndex >= 0 && endIndex <= input.Length-1)
                        {
                            input = input.Remove(startIndex, endIndex+1-startIndex);
                        }
                    Console.WriteLine(input);
                }
                else // "Switch"
                {
                    string oldString = command[1];
                    string newString = command[2];

                    if (input.Contains(oldString))
                    {
                        input = input.Replace(oldString, newString);
                    }
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}