internal class Program
{
    private static void Main(string[] args)
    {
        List<string> dungeonRooms = Console.ReadLine()
             .Split("|", StringSplitOptions.RemoveEmptyEntries)
             .ToList();

       

        int health = 100;
        int bitcoin = 0;

        for (int i = 0; i < dungeonRooms.Count; i++)
        {
            List<string> anyRoom = new List<string>() { dungeonRooms[i] }; // rat 10

            string command = anyRoom[0];
            string number = anyRoom[1];


            if (command == "potion")
            {
                if (health < 100 )
                {
                    health += 0;
                }
                else
                {
                    health = 100;
                }
            }
            else if (command == "chest")
            {

            }
            else
            {

            }
        }
    }
}