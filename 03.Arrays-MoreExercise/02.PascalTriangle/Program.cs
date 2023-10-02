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
               
                for (int col = 1; col <= r; col++)
                {
                    current[col] = row[col - 1] + row[col];
                    Console.Write($"{current[col]} ");
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