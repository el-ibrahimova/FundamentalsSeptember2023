namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endValue = int.Parse(Console.ReadLine());

            for (int i = 1; i < endValue; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }


            static bool IsTopNumber(int num)
            {
                if (IsDivisibleByEight(num) && HasOddNumber(num))
                {
                    return true;
                }
                return false;
            }

            static bool HasOddNumber(int num)
            {
                while (num > 0)
                {
                    int digit = num % 10; // get digit

                    if (digit % 2 != 0)
                    {
                        return true;
                    }
                    num /= 10;
                }
                return false;

            }

            static bool IsDivisibleByEight(int num)
            {
                int sumOfAllDigits = 0;

                while (num > 0)
                {
                    int digit = num % 10; // get digit
                    sumOfAllDigits += digit; // sum
                    num /= 10; //get next digit
                }

                return sumOfAllDigits % 8 == 0;
            }
        }
    }
}