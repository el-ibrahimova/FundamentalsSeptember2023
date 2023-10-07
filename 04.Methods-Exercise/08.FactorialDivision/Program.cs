namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int factorial1 = FactorialNum1(num1);
            int factorial2 = FactorialNum2(num2);

            PrintResult(factorial1, factorial2);
        }

        private static void PrintResult(int factorial1, int factorial2)
        {
            double result = (double)factorial1 / factorial2;
            Console.WriteLine($"{result:f2}");
        }

        private static int FactorialNum1(int num1)
        {
            int factorial = 1;
            for (int i = 0; i < num1; i++)
            {
                factorial *= (num1 - i);
            }
            return factorial;
        }

        private static int FactorialNum2(int num2)
        {
            int factorial = 1;
            for (int i = 0; i < num2; i++)
            {
                factorial *= (num2 - i);
            }
            return factorial;
        }
    }
}