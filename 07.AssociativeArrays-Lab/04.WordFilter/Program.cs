namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
               .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

           
            // може да се запише и по-кратко

            //     Console.ReadLine()
            //   .Split()
            //   .Where(x => x.Length % 2 == 0)
            //   .ToList()
            //   .ForEach(Console.WriteLine) ;  // този ForEach работи само за листове


        }
    }
}