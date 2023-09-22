using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        char letter = char.Parse(Console.ReadLine());

        bool isUp = char.IsUpper(letter);

        if (isUp == true)
        {
            Console.WriteLine("upper-case");
        }
        else if (isUp == false)
        {
            Console.WriteLine("lower-case");
        }
    }
}