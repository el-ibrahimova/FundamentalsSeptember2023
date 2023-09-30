namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split();
            int[] array = new int[inputArr.Length];

            for (int i = 0; i < inputArr.Length; i++)
            {
                array[i] = int.Parse(inputArr[i]);
            }


            for (int i = 0; i < array.Length; i++)
            {
                bool isTop = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTop = false;
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
    
