namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                if (arguments[0] == "Add")
                {
                    int number = int.Parse(arguments[1]);
                    numbers.Add(number);
                }
                else if (arguments[0] == "Insert")
                {
                    int number = int.Parse(arguments[1]);
                    int index = int.Parse(arguments[2]);

                    if (IsNotValidIndex(index, numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }

                }
                else if (arguments[0] == "Remove")
                {
                    int index = int.Parse(arguments[1]);

                    if (IsNotValidIndex(index, numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);  // този метод премахва елемента от даден индекс, както е по условие
                    }

                }
                else if (arguments[0] == "Shift")
                {
                    int count = int.Parse(arguments[2]);
                    string direction = arguments[1];
                    count = count % numbers.Count; 
                    // 20 % 5 = 0 // Превъртаме count, за да бъде в границите на листа
                    // [1 2 3 4 5]

                    if (direction == "left")
                    {
                        // numbers = [1 2 3 4 5]
                        List<int> shiftedPart = numbers.GetRange(0, count);
                        // shiftedPart = [ 1 2 3], ako count =3
                        numbers.RemoveRange(0, count);
                        //numbers = [4 5]
                        numbers.InsertRange(numbers.Count, shiftedPart);
                        // numbers = [4 5 1 2 3]
                    }
                    else if (direction == "right")
                    {
                        List<int> shiftedPart = numbers.GetRange(numbers.Count - count, count);
                        numbers.RemoveRange(numbers.Count - count, count);
                        numbers.InsertRange(0, shiftedPart);

                    }
                }

            }
            Console.WriteLine(string.Join(" ", numbers));

        }

        static bool IsNotValidIndex(int index, int numbersCount)
        {
            return index < 0 || index >= numbersCount;
        }
    }
}