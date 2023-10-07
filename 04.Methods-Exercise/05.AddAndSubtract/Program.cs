namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            SumSubstractsThird(first, second, third);
            int result = SumSubstractsThird(first, second, third);
            Console.WriteLine(result);
        }

        static int SumSubstractsThird(int first, int second, int third)
        {
            int sum = SumFirstAndSecond(first, second);
            return sum - third;
        }

        static int SumFirstAndSecond(int first, int second)
        {
            return first + second;
        }
    }
}