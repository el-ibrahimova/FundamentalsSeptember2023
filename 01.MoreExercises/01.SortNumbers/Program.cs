namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int max;
            int min;
            int mid;

            if (firstNumber > secondNumber)
            {
                mid = firstNumber;
                min = secondNumber;
            }
            else
            {
                mid = secondNumber;
                min = firstNumber;
            }

            if (mid > thirdNumber)
            {
                max = mid;
                if (min > thirdNumber)
                {
                    mid = min;
                    min = thirdNumber;
                }
                else
                {
                    mid = thirdNumber;
                }
            }
            else max = thirdNumber;


            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);

        }
    }
}