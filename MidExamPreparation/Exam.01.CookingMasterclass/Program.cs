namespace Exam._01.CookingMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double totalCost = 0;
            int freePackage = 0;
          
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freePackage++;
                }
            }
            apronPrice = apronPrice* students * 1.2;
            eggPrice = eggPrice * 10 * (students);
            flourPrice = flourPrice * (students - freePackage);

                totalCost =Math.Ceiling(apronPrice) + eggPrice + flourPrice;

            if (budget >= totalCost )
            {
                Console.WriteLine($"Items purchased for {totalCost:f2}$.");
            }
            else 
            {
                Console.WriteLine($"{totalCost-budget:f2}$ more needed.");
            }
        }
    }
}