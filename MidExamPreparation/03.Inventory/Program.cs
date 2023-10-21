using System.Threading.Tasks.Dataflow;

namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(", ")
                .ToList();

            List<string> commands = Console.ReadLine().Split(" - ").ToList();

            string input = commands[0];
            while (input != "Craft!")
            {
               
                if (input == "Collect")
                {
                    string item = commands[1];
                    if (journal.Contains(item))
                    {
                        continue;
                    }
                    else
                    { 
                    journal.Add(item);
                    }

                }
                else if (input == "Drop")
                {
                    string item = commands[1];
                    if (journal.Contains(item))
                    {
                         journal.Remove(item);
                    }
                   
                }
                else if (input == "Combine Items")
                {
                    string[] item = commands[1].Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string oldI = item[0];
                    string newI = item[1];


                    if (journal.Contains(oldI))
                    {
                        int indexOfOldItem = journal.IndexOf(oldI);
                        journal.Insert(indexOfOldItem + 1, newI);
                    }
                    
                }
                else if (input == "Renew")
                {
                    string item = commands[1];
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                        journal.Add(item);
                    }

                }

                commands = Console.ReadLine().Split(" - ").ToList();
                input = commands[0];
            }

            Console.WriteLine(string.Join(", ", journal));

        }
    }
}