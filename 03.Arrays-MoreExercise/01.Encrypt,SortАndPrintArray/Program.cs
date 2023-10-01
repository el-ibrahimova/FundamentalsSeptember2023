namespace _01.Encrypt_SortАndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];
            int[] currentNameValue = new int[n]; 
            int sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();
                string currentName = names[i];

                sum = 0;

                for (int j = 0; j < currentName.Length; j++)
                {
                    char digit = currentName[j];
                    int value = (int)digit;

                     if (digit == 'a' || digit == 'i' || digit == 'o' || digit == 'u' || digit == 'e'
                      || digit == 'A' || digit == 'I' || digit == 'O' || digit == 'U' || digit == 'E')
                        {
                            sum += value * currentName.Length;
                        }
                        else
                        {
                            sum += value / currentName.Length;
                        }
                }
                currentNameValue[i] = sum;

            }
            Array.Sort(currentNameValue);
            for (int i = 0; i < currentNameValue.Length; i++)
            {
                Console.WriteLine(currentNameValue[i]);
            }

        }
    }
}
              