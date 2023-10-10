/*
 * You are given a positive integer number and one binary digit B (0 or 1). Your task is to write a program that finds the number of binary digits (B) in a given integer.
*/

namespace _01.BinaryDigitsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberInDecimal = double.Parse(Console.ReadLine());
            int binaryDigit = int.Parse(Console.ReadLine());
            int countOfDigits = 0;

            while (numberInDecimal > 0)
            {
         double remainder = numberInDecimal % 2;
                numberInDecimal = Math.Floor(numberInDecimal / 2);

                if (remainder == binaryDigit)
                {
                    countOfDigits++;
                }
            }
            Console.WriteLine(countOfDigits);

        }
    }
}