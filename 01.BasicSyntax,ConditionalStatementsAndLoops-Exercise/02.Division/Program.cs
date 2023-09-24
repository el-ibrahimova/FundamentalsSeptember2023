namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bigger = 1;

            if (number % 10 != 0 && number % 7 != 0 && number % 6 != 0 && number % 3 != 0 && number % 2 != 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                if (number % 10 == 0) { bigger = 10; }
                else if (number % 7 == 0) { bigger = 7; }
                else if (number % 6 == 0) { bigger = 6; }
                else if (number % 3 == 0) { bigger = 3; }
                else if (number % 2 == 0) { bigger = 2; }

                Console.WriteLine($"The number is divisible by {bigger}");
            }
        }
    }
}