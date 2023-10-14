namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();


                if (arguments[0] == "Add")
                {
                    numbers.Add(arguments[1]);
                }
                else if (arguments[0] == "Insert")
                {
                }
                else if (arguments[0] == "Remove")
                {

                }
                else if (arguments[0] == "Shift")
                {
                    if (arguments[1] == "left")
                    {

                    }
                    else if (arguments[1] == "right")
                    { 
                    
                    }
                }
            
            }

        }
    }
}