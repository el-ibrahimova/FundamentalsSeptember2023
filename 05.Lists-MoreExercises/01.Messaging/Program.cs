namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {  
                List<int> numbers = Console.ReadLine().
                    Split().
                    Select(int.Parse).
                    ToList();

                List<char> text = Console.ReadLine().ToList();

                List<char> letters = new List<char>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    int currentIndex = GetIndex(numbers[i], text.Count);
                    letters.Add(text[currentIndex]); // прибавяме буквите в новия лист
                    text.RemoveAt(currentIndex);
                }
                Console.WriteLine(string.Join("", letters));
            }
            static int CalculateSum(int currentNumber) 
            // изчисляваме сумата на всеки елемент от листа => от тук получваме кой индекс да вземем от листа text
            {
                int sum = 0;
                while (currentNumber > 0)
                {
                    int lastDigit = currentNumber % 10;
                    sum += lastDigit;
                    currentNumber /= 10;
                }
                return sum;
            }
            static int GetIndex(int currentNumber, int count)
            // с този метод намираме на кой индекс( и как да го валидираме, за да не е извън границите) е буквата от новия ни лист
            {
                int index = CalculateSum(currentNumber);

                if (index > count)
                {
                    if (index % count == 0)
                    {
                        index = count - 1;
                    }
                    else
                    {
                        index %= count;
                    }
                }
                return index;
            }
        }
    }

  