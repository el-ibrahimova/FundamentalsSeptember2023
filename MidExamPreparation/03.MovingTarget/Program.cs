namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToList();

            List <string> input = Console.ReadLine().Split().ToList();

            string command = input[0];

           
            while (command != "End")
            {
                int index = int.Parse(input[1]);

                if (command == "Shoot")
                {
                    int power = int.Parse(input[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    int value = int.Parse(input[2]);

                    if (index >= 0 && index < input.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int radius = int.Parse(input[2]);
                    int radiusRight = index + radius;
                    int radiusLeft = index - radius;

                    if (radiusLeft >= 0 && radiusRight < targets[targets.Count - 1])
                    {
                        // трябва изтриването на индексите да върви от дясно на ляво, за да не се налага преоразмеряването на листа

                        for (int i = 1; i <= radius; i++)
                        {
                            targets.RemoveAt(index + i);
                        }

                        targets.RemoveAt(index);

                        for (int i = 1; i <= radius; i++)
                        {
                            targets.RemoveAt(index - i);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}