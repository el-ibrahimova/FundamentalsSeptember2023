namespace _03.Santa_sNewList
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            // name, points
            Dictionary<string, int> childrens = new Dictionary<string, int>();

            //present, points
            Dictionary<string, int> presents = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] info = input.Split("->");

                if (info[0] != "Remove")
                {
                    string name = info[0];
                    int amount = int.Parse(info[2]);
                    string present = info[1];

                    if (!childrens.ContainsKey(name) ) 
                    {
                        childrens.Add(name, amount);                    
                    }
                    else
                    {
                        childrens[name] += amount;                        
                    }
                   
                    if (!presents.ContainsKey(present))
                    {                       
                        presents.Add(present, amount);
                    }
                    else
                    {                
                        presents[present] += amount;
                    }
                }
                else
                {
                    string childName = info[1];
                    childrens.Remove(childName);
                }
            }

            Console.WriteLine("Children:");
            foreach (var ch in childrens.OrderByDescending(t => t.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }

            Console.WriteLine("Presents:");
            foreach (var ch in presents)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}