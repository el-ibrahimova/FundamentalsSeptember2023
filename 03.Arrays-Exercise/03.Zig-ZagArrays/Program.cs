namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4
            int n = int.Parse(Console.ReadLine());
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();       // "1 5" 
                string[] numbersArray = numbers.Split();   // ["1", "5"] 

                firstArr[i] = numbersArray[0];
                secondArr[i] = numbersArray[1];
            }

            Console.WriteLine(string.Join(" ",firstArr));
            Console.WriteLine(string.Join(" ", secondArr));

        }
    }
}