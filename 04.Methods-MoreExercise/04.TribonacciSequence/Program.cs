using System;
using System.Xml.Serialization;

namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] array = new int[num];

            TribonacciSequence(num, array);
        }

        static void TribonacciSequence(int num, int[] array)
        {
            for (int i = 0; i < num; i++)
            {
                if (i == 0 || i == 1)
                {
                    array[i] = 1;
                }
                else if (i == 2)
                {
                    array[i] = array[i - 1] + array[i - 2];
                }
                else if (num >= 3)
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3];
                }
            }
            Console.WriteLine(string.Join(" ", array));
        }

    }
}