namespace _05.BombNumbers
{
/*
1 2 2 4 2 2 2 9
4 2
*/

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            
            List<int> bomb = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int number = bomb[0];
            int power = bomb[1];

            while (list.Contains(number)) // докато бомбата съществува в този лист
            {
                int index = list.IndexOf(number);
                // [1 2 2 4 2 2 2 9]
                // При индекс 3 е стойността 4, което е числото бомба

                int leftIndex = Math.Max(0, index - power);
                // връща като стойностст по-малкото число
                // за да не излезнем от границите на листа


                int rightIndex = Math.Min(list.Count - 1, index + power);

                int range = rightIndex - leftIndex + 1;
                // границите на дясно + границите на ляво + числото бомба

                list.RemoveRange(leftIndex, range); // Начален индекс до дължината на границата
            
            }

            Console.WriteLine(list.Sum());

        }
    }
}