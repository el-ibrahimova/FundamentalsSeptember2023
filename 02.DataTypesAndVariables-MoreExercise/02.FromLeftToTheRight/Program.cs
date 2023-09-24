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
                string left = "";
                string right = "";
                long leftSum = 0, rightSum = 0;

                for (int j = 0; j < num.IndexOf(' '); j++)
                {
                    left += num[j];
                }

                for (int k = num.IndexOf(' '); k < num.Length; k++)
                {
                    right += num[k];
                }
            
                    leftSum = long.Parse(left);
                    rightSum = long.Parse(right);

                    long sum = 0;
                    if (leftSum > rightSum)
                    {
                        while (leftSum > 0)
                        {
                            long lastDigit = leftSum % 10;
                            sum += lastDigit;
                            leftSum /= 10;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        while (rightSum > 0)
                        {
                            long lastDigit = rightSum % 10;
                            sum += lastDigit;
                            rightSum /= 10;
                        }
                        Console.WriteLine(sum);
                    }
                }

            }
         
        }
    }
