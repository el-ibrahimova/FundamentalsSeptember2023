internal class Program
{
    private static void Main(string[] args)
    {
        double britishPound = double.Parse(Console.ReadLine());
        double usdDollar = britishPound * 1.31;

        Console.WriteLine($"{usdDollar:f3}");
    }
}