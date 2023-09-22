internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        decimal sum = 0;

        for (int i = 1; i <= n; i++)
        {
            decimal currentNumber = decimal.Parse(Console.ReadLine());
            sum += currentNumber;
        }

        Console.WriteLine(sum);
    }
}