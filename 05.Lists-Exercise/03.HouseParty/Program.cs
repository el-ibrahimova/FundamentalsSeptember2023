namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestCount = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < guestCount; i++)
            {
                string [] argument= Console.ReadLine().Split();
                string name = argument[0];

                if (argument[2] == "going!")
                {
                    if (guestList.Exists(e => e == name)) // проверяваме във всеки елемент дали въведеното име вече съществува в списъка
                                                          // ако съществува, то не го добавяме
                                                          // може да се реши и с метода FindIndex, той връща за инедкс стойност -1, ако няма такъв индекс
                                                          // т.е. няма такъв елемент
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (argument[2] == "not")
                {
                    if (guestList.Contains(name)) // друг метод, с който проверяваме дали елемента съществува в списъка
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                } 
            }

            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
        
    }
}