using System;
using System.Globalization;
using System.Reflection;

namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int count = originalArray.Length;
          
            while (count > 1)
            {
                for (int i = 0; i < count-1; i++)
                {
                    int[] condenced = new int[count];

                        condenced[i] = originalArray[i] + originalArray[i + 1];
                    originalArray[i] = condenced[i];
                }
               count--;
            }

            Console.WriteLine(originalArray[0]);
        }
        }
    }
