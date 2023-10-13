namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> originalNumbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            List<int> copiedNumbers = new List<int>(originalNumbers);

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            bool changesMade = false;

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input
                    .Split()
                    .ToList();

                string command = commands[0];

                if (command == "Add" || command == "Remove" || command == "RemoveAt" || command == "Insert")
                {
                    changesMade = true;
                }

                List<int> filteredNumbers = new List<int>();

                if (command == "Add")
                {
                    int numberToAdd = int.Parse(commands[1]);
                    copiedNumbers.Add(numberToAdd);
                }
                else if (command == "Remove")
                {
                    int numberToRemove = int.Parse(commands[1]);
                    copiedNumbers.Remove(numberToRemove);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);
                    copiedNumbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int numberToInsert = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    copiedNumbers.Insert(index, numberToInsert);
                }
                else if (command == "Contains")
                {
                    int containedNumber = int.Parse(commands[1]);

                    if (originalNumbers.Contains(containedNumber))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    PrintingEvenNumbers(originalNumbers, evenNumbers);
                }
                else if (command == "PrintOdd")
                {
                    PrintingOddNumbers(originalNumbers, oddNumbers);
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(originalNumbers.Sum());
                }
                else if (command == "Filter")
                {
                    FilterCommand(originalNumbers, commands, filteredNumbers);
                }

                
            }

            ChekingForChanges(changesMade, copiedNumbers);
        }

        private static void ChekingForChanges(bool changesMade, List<int> copiedNumbers)
        {
            if (changesMade)
            {
                Console.WriteLine(string.Join(' ', copiedNumbers));
            }
        }

        private static void FilterCommand(List<int> numbers, List<string> commands, List<int> filteredNumbers)
        {
            string condition = commands[1];

            int filterNumber = int.Parse(commands[2]);

            if (condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }

                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
            else if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }

                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }

                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }

                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
        }

        private static void PrintingOddNumbers(List<int> numbers, List<int> oddNumbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", oddNumbers));
        }

        private static void PrintingEvenNumbers(List<int> numbers, List<int> evenNumbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}

