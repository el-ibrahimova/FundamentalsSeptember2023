internal class Program
{
    private static void Main(string[] args)
    {
        double length, width, height = 0;
        length = double.Parse(Console.ReadLine());
        width = double.Parse(Console.ReadLine());
        height = double.Parse(Console.ReadLine());
               
        Console.Write("Length: ");
        Console.Write("Width: ");
        Console.Write("Height: ");

       double volume = (length * width * height) /3;

        Console.Write($"Pyramid Volume: {volume:f2}");
    }
}