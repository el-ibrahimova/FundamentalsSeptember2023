namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            while (input != "END")
            {
                // Anything coming as an input from the console is considered a string type.
                // In C# you need to parse your input into a specific type where possible.
                // `typeToCheck`.TryParse(input, out _) - Will return True if parsing is possible.            

                if (Int32.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else // since you cannot parse to string ... if the previous statements came up false -> IT's STRING Type.
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
                
            }

        }
    }
}