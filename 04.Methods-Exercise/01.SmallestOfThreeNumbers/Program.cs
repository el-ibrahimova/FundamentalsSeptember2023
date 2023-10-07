namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int smallestNumber = SmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(smallestNumber);

        }

        static int SmallestNumber(int first, int second, int third)
        {
            int max;
            int min;
            int mid;

            if (first > second)
            {
                mid = first;
                min = second;
            }
            else
            {
                mid = second;
                min = first;
            }

            if (mid > third)
            {
                max = mid;
                if (min > third)
                {
                    mid = min;
                    min = third;
                }
                else
                {
                    mid = third;
                }
            }
            else max = third;


            return min;
        }
    }
}