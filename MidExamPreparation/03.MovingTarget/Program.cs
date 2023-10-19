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
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] comArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstCom = comArg[0];
                int index = int.Parse(comArg[1]);
                int power = int.Parse(comArg[2]);
                if (firstCom == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        if (targets[index] > power) // if targets is bigger than power
                        {
                            targets[index] -= power;
                        }
                        else
                        {
                            targets.RemoveAt(index);
                        }

                    }
                }

                else if (firstCom == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, power);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                }

                else if (firstCom == "Strike")
                {

                    if (index - power >= 0 && index + power < targets.Count) // validate index and radius
                    {

                        for (int i = 1; i <= power; i++)
                        {
                            targets.RemoveAt(index + i);
                        }
                        targets.RemoveAt(index);
                        for (int i = 1; i <= power; i++)
                        {
                            targets.RemoveAt(index - i);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}