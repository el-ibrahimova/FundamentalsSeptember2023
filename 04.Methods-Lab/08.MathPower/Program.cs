namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int result = GetMathPower(number, power);
            Console.WriteLine(result);


        }

         static int GetMathPower(int number, int power)
        {
            int result = (int)Math.Pow(number, power);
            return result;
            
        }
    }
}