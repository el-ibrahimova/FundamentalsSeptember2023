namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();
              
                int indexSpace = num.IndexOf(' ');
                string left = num.Substring(0, num.IndexOf(" "));
                string right = num.Substring(num.IndexOf(" ") + 1);
               
              //  for (int j = 0; j < indexSpace; j++)
              //  {
              //  left += num[j];
              //  }

              //  for (int k = indexSpace; k < num.Length; k++)
              //  {
              //  right += num[k];
              //  }

                long leftSum = Convert.ToInt64(left);
                long rightSum = Convert.ToInt64(right);

                long sumDigits = 0;
                if (leftSum >= rightSum)
                {
                    while (leftSum != 0)
                    {
                        sumDigits += leftSum % 10;
                        leftSum /= 10;
                    }
                }
                else
                {
                    while (rightSum != 0)
                    {
                        sumDigits += rightSum % 10;
                        rightSum /= 10;
                    }

                }
                Console.WriteLine(Math.Abs(sumDigits));

            }

        }
    }
}
