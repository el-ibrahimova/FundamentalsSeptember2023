namespace P_thBit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            
            int shiftedNumber = number >> position; // в числото number изместваме наляво position пъти

            int result = shiftedNumber & 1; // полученото число, след изместваме, умножаваме с логически оператор & по 1,
                                            // ако последната цидра е 1 резултата е 1, ако е 0 => резултата е 0
            Console.WriteLine(result);

        }
    }
}