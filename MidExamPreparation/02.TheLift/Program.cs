namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagon = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < wagon.Length; i++)
            {
                int currentWagon = wagon[i];

                if (currentWagon < 4)
                {
                    int emptySeats = 4 - wagon[i];
                    people -= emptySeats;
                    if (people < 0)
                    {
                        wagon[i] = 4 - Math.Abs(people);
                        Console.WriteLine("The lift has empty spots!");
                        PrintWagon(wagon);
                        return;
                    }
                    wagon[i] = 4;
                }
            }

            if (people != 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                PrintWagon(wagon);
            }
            else // people = 0 && wagons =0
            {
                PrintWagon(wagon);
            }
        }

        static void PrintWagon(int[] wagon)
        {
            Console.WriteLine(string.Join(" ", wagon));
        }
    }

}