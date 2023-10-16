namespace _06.Tri_bitSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 7 << position;// числото 7 в двуична система се записва като 111. За да вземем 3 последователни 
            // стойности от числото number използваме него
            // с оператор << изместваме position пъти трите числа до търсената позиция в числото number 

            int result = number ^ mask;//1 ^ 1 = 0, 0 ^ 1 = 1
            // с оператора ^ обръщаме стойностите на клетките и получаваме резултата
            Console.WriteLine(result);
        }
    }
}