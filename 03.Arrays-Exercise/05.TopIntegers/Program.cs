namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
           
            for (int i = 0; i < array.Length; i++)
            {
                bool isTop = true;

                for (int j = i + 1; j < array.Length; j++) // j= i+1 => от условието на задачата => търсим числата на дясно от първото
                {
                    if (array[i] <= array[j])
                    {
                        isTop = false;
                        break;
                    }
                }


                if (isTop)
                {
                    Console.Write($"{array[i]} ");
                }
            }

        }
    }
}
    
