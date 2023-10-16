namespace _04.BitDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

           
            // трябва да променим числото на позиция пosition  да стане 0

            // преместваме position пъти числото 1 до нужната позиция
             
            // 010100100001 = number
            // 000000100000 = mask
            // 111111011111 = reversed
            
            // 010100000001 = result
            
            
            int mask = 1 << position;
            int reversed = ~mask;
            int result = number & reversed;
            Console.WriteLine(result);
        }
    }
}