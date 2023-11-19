namespace _05.NetherRealms
{
    public class Demon
    {
        public string Name { get; set; }
        public double Health { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Demon> demons = new List<Demon>();

            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                string demonName = input[i];


            }
        }
    }
}