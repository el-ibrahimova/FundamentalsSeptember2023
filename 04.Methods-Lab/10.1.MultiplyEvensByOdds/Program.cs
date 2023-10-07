namespace _10._1.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            while (number > 0)
            {
                int currentNumber = number % 10;

                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }

                number /= 10;
            }
            Console.WriteLine(sumOdd*sumEven);
        }
    }
}