namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());
            long[] row = new long[lines];
            long[] current = new long[lines];
           
            row[0] = 1; //Startup row is always equal to "1"
            Console.WriteLine(row[0]);
          
            for (int r = 1; r < lines; r++)
            {
                current[0] = 1; //Every 1st value in the row is always equal to "1"
                Console.Write($"{current[0]} ");
               
                for (int c = 1; c <= r; c++)
                {
                    current[c] = row[c - 1] + row[c];
                    Console.Write($"{current[c]} ");
                }
                for (int j = 0; j < lines; j++)
                {
                    row[j] = current[j];
                }
                Console.WriteLine();
            }

        }
    }
}