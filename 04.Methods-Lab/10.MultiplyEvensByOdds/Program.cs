namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();

            int sumOfEven = GetSum(numberAsString, true);
            int sumOfOdd = GetSum(numberAsString, false);

           Console.WriteLine(sumOfOdd*sumOfEven);
        }

        static int GetSum(string numbers, bool isEven)
        {
            // "1234"

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (char.IsDigit(numbers[i])) // проверяваме дали символа е число, в случай че има "-"
               //друг вариант => if (numbers[i] >=48 && numbers[i] <=57)   ==> от ASCII таблицата (числата от 0 до 9 са на позиции от 48 до 57)
                {
                    int currentNumber = int.Parse(numbers[i].ToString()); // "1234" => '1' => "1"

                    if (currentNumber % 2 == 0 && isEven)
                    {
                        sum += currentNumber;
                    }
                    else if (currentNumber % 2 != 0 & !isEven)
                    {
                        sum += currentNumber;
                    }
                }
            }

            return sum;
        }
    }
}