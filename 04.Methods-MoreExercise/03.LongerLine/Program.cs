namespace _03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstX1 = double.Parse(Console.ReadLine());
            double firstY1 = double.Parse(Console.ReadLine());
            double firstX2 = double.Parse(Console.ReadLine());
            double firstY2 = double.Parse(Console.ReadLine());

            double secondX1 = double.Parse(Console.ReadLine());
            double secondY1 = double.Parse(Console.ReadLine());
            double secondX2 = double.Parse(Console.ReadLine());
            double secondY2 = double.Parse(Console.ReadLine());


        //    (x1 - x2) ^ 2 + (y1 - y2) ^ 2

            double first = Math.Sqrt(Math.Pow(firstY1-firstY2, 2) + Math.Pow(firstX1-firstX2, 2));
            double second = Math.Sqrt(Math.Pow(secondY1 -secondY2, 2) + Math.Pow(secondX1-secondX2, 2));

            if (first > second)
            {
                Console.WriteLine($"({firstX2}, {firstY2})({firstX1}, {firstY1})");
            }
            else if (second > first)
            {
                Console.WriteLine($"({secondX2}, {secondY2})({secondX1}, {secondY1})");
            }
        }
    }
    
}