﻿namespace Exam._01.CookingMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float flourPrice = float.Parse(Console.ReadLine());
            float eggPrice = float.Parse(Console.ReadLine());
            float apronPrice = float.Parse(Console.ReadLine());

            float totalCost = 0;
            int freePackage = 0;
          
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freePackage++;
                }
            }
            float totalApronPrice = (float)Math.Ceiling(students*1.2)*apronPrice;
            float totalEggPrice = eggPrice * 10 * (students);
            float totalFlourPrice = flourPrice * (students - freePackage);

                totalCost =totalApronPrice + totalEggPrice + totalFlourPrice;

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