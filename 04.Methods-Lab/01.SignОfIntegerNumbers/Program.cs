namespace _01.SignОfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNumberSign(n);
        }

        private static void PrintNumberSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else // zero
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}