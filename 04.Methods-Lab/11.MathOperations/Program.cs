namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            double result = Calculate(firstNum, operation, secondNum);
            Console.WriteLine(result);
        }

        static double Calculate(double a, string operation, double b)
        {
            double result = 0;

            switch (operation)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/": result = a / b; break;
            }

            return result;
        }
    }
}