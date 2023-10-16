/*
Write a program that prints the bit at position 1 of the given integer. 
We use the standard counting: from right to left, starting from 0.
*/

namespace _02.BitAtPosition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int shiftedNumber = 1 << 1;// след изместване на ляво с 1 клетка ние имаме стойността 1 в shiftedNumber на позиция 1, а другите са 0

            int result = (number & shiftedNumber) >> 1;// след изместване на дясно с 1 взимаме последната стойност (0 или 1)
                                                       // защото другите са 0 използвайки логическия оператор & == умножение
            Console.WriteLine(result);

        }
    }
}