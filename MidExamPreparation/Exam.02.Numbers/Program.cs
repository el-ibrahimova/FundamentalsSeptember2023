namespace Exam._02.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            string command = input[0];

            while (command != "Finish")
            {
                int value = int.Parse(input[1]);

                if (command == "Add")
                {
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    if (numbers.Contains(value))
                    {
                        numbers.Remove(value);
                    }
                }
                else if (command == "Replace")
                {
                    int replacement = int.Parse(input[2]);

                    if (numbers.Contains(value))
                    {
                        int index = numbers.IndexOf(value);
                        numbers.RemoveAt(index);
                        numbers.Insert(index, replacement);
                    }
                }
                else if (command == "Collapse")
                {
                    numbers.RemoveAll(x => x < value);
                }

                input = Console.ReadLine().Split().ToArray();
                command = input[0];
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}