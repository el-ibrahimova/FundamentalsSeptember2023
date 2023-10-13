namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string line;
            bool isAnyChanges = false;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] lineTokens = line.Split().ToArray();
                string command = lineTokens[0];

                

                if (command == "Contains")
                {
                    int number = int.Parse(lineTokens[1]);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }


                if (command == "PrintEven")
                {
                    List<int> evenNumber = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            evenNumber.Add(numbers[i]);

                        }
                    }
                    Console.WriteLine(string.Join(" ", evenNumber));
                }

                if (command == "PrintOdd")
                {
                    List<int> oddNumber = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            oddNumber.Add(numbers[i]);

                        }
                    }
                    Console.WriteLine(string.Join(" ", oddNumber));
                }

                if (command == "GetSum")
                { 
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }

                
                if (command == "Filter")
                {
                    string condition = lineTokens[1];
                    int numberToFilter = int.Parse(lineTokens[2]);

                    if (condition == ">")
                    {
                        List<int> conditionBigger = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > numberToFilter)
                            {
                                conditionBigger.Add(numbers[i]);
                            }
                            isAnyChanges = true;
                            numbers = conditionBigger;
                            Console.Write(string.Join(" ", conditionBigger));
                            
                        }
                    }
                    else if (condition == "<")
                    {
                        List<int> conditionSmaller = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < numberToFilter)
                            {
                                conditionSmaller.Add(numbers[i]);
                            }
                            isAnyChanges = true;
                            numbers = conditionSmaller;
                            Console.Write(string.Join(" ", conditionSmaller));
                            
                        }
                    }
                    else if (condition == ">=")
                    {
                        List<int> conditionBiggerOrEqual = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= numberToFilter)
                            {
                                conditionBiggerOrEqual.Add(numbers[i]);
                            }
                            isAnyChanges = true;
                            numbers = conditionBiggerOrEqual;
                            Console.Write(string.Join(" ", conditionBiggerOrEqual));
                           
                        }
                    }
                    else if (condition == "<=")
                    {
                        List<int> conditionSmallerOrEqual = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= numberToFilter)
                            {
                                conditionSmallerOrEqual.Add(numbers[i]);
                            }
                            isAnyChanges = true;
                             numbers = conditionSmallerOrEqual;
                            Console.Write(string.Join(" ", conditionSmallerOrEqual));
                           
                        }
                    }

                }
            }


            if (isAnyChanges == true)
            { 
                Console.WriteLine(string.Join(" ", numbers)); 
            }
        }
    }
}