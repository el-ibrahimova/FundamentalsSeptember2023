namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4
            int n = int.Parse(Console.ReadLine());
            bool isFirstArrSelected = true;

            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();       // "1 5" 
                string[] numbersArray = numbers.Split();   // ["1", "5"] 

                if (isFirstArrSelected)
                {
                    firstArr[i] = numbersArray[0];
                    secondArr[i] = numbersArray[1];
                }
                else 
                {
                    firstArr[i] = numbersArray[1];
                    secondArr[i] = numbersArray[0];
                }

                isFirstArrSelected = !isFirstArrSelected;
            }

            Console.WriteLine(string.Join(" ",firstArr));
            Console.WriteLine(string.Join(" ", secondArr));

        }
    }
}