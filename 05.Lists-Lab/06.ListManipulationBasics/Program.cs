namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string line;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] lineTokens = line.Split().ToArray();
                string command = lineTokens[0];
                int number = int.Parse(lineTokens[1]); 
                
                
                if (command == "Add") // на първи индекс стои числото, което трябва да добавим = Add 3
                {  
                     numbers.Add(number);
                }
                else if (command == "Insert") // Insert 8 3
                {  
                    int index = int.Parse(lineTokens[2]);
                    numbers.Insert(index, number);
                }
                else if (command == "Remove")  // Remove 2
                {
                    numbers.Remove(number);
                }
                else if (command == "RemoveAt")  // RemoveAt 1
                {
                    int index = number;
                    numbers.RemoveAt(index);
                }

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
    
}