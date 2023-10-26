using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace _02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;

            for (int i = n; i >= 2; i--)
            {
                factoriel *=(BigInteger)i;
            }

            Console.WriteLine(factoriel);
        }
    }
}