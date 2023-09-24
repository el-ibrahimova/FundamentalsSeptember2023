namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = lostGamesCount / 2;
            int trashedMouse = lostGamesCount / 3;
            int trashedKeyboard = lostGamesCount / 6;
            int trashedDisplay = trashedKeyboard / 2;

            double totalExpenses = headsetPrice * trashedHeadset + mousePrice * trashedMouse + keyboardPrice * trashedKeyboard + displayPrice * trashedDisplay;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}