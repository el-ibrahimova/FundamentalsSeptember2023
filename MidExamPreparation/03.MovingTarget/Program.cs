using System;

namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> manipulate = Console.ReadLine().Split().ToList();

            string input = manipulate[0];

            while (input != "End")
            {
                if (input == "Shoot")
                {
                    Shoot(target, manipulate);

                }
                else if (input == "Add")
                {
                    Add(target, manipulate, input);

                else if (input == "Strike")
                    {

                    }

                    manipulate = Console.ReadLine().Split().ToList();

                }
            }

            static void Shoot(List<int> target, List<string> manipulate)
            {
                int index = int.Parse(manipulate[1]);
                int power = int.Parse(manipulate[2]);

                if (index >= 0 && index < target.Count)
                {
                    int reducing = target[index] - power;
                    target[index] = reducing;

                    if (reducing < 0)
                    {
                        target.RemoveAt(index);
                    }
                }
            }
        }

        static void Add(List<int> target, List<string> manipulate, string input)
        {
            int index = int.Parse(manipulate[1]);
            int value = int.Parse(manipulate[2]);

            if (index >= 0 && index < target.Count)
            {
                target.Insert(index, value);
            }
            else if (index < 0 || index >= target.Count)
            {
                Console.WriteLine("Invalid placement!");
            }

        }
    } }