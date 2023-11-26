namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> res = new Dictionary<string, int>();

      
            while (true)
            {
                      string input = Console.ReadLine();
                
                if (input == "stop")
                {
                    break;
                }

               


                if (!res.ContainsKey(input))
                {
                    res.Add(input, 0);
                }
                
                int quantity =int.Parse(Console.ReadLine());
                res[input] += quantity;
                
            }

            foreach (var some in res)
            {
                Console.WriteLine($"{some.Key} -> {some.Value}");
            }

        }
    }
}