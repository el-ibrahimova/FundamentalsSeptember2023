namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine().Split('!').ToList();

            List<string> command = Console.ReadLine().Split().ToList();
            string input = command[0];


            while (input != "Go Shopping!")
            {

                if (command[0] == "Go")
                {
                    break;
                }
                else if (command[0] == "Urgent")
                {
                    string item = command[1];
                    if (!initialList.Contains(item))
                    {
                        initialList.Insert(0, item);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    string item = command[1];
                    if (initialList.Contains(item))
                    {
                        initialList.Remove(item);
                    }
                }
                else if (command[0] == "Correct")
                {
                    string oldItem = command[1];
                    string newItem = command[2];
                    if (initialList.Contains(oldItem))
                    {
                        int indexOfOldItem = initialList.IndexOf(oldItem);
                        initialList.Remove(oldItem);
                        initialList.Insert(indexOfOldItem, newItem);
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    string item = command[1];
                    if (initialList.Contains(item))
                    {
                        initialList.Remove(item);
                        initialList.Add(item);
                    }
                }

                command = Console.ReadLine().Split().ToList();
                input = command[0];
            }

            Console.Write(string.Join(", ", initialList));

        }
    }
}