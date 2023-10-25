namespace _02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int factoriel = 1;

            for (int i = n; i >= 2; i--)
            {
                factoriel *= i;
            }

            Console.WriteLine(factoriel);
        }
    }
}