internal class Program
{
    private static void Main(string[] args)
    {
        int students = int.Parse(Console.ReadLine());
        int lectures = int.Parse(Console.ReadLine());
        int additionalBonus = int.Parse(Console.ReadLine());

        double totalBonus;
        double maxBonus = int.MinValue;
        double studentMaxAttendance = 0;

        for (int i = 1; i < students; i++)
        {
            double attendance = double.Parse(Console.ReadLine());

            totalBonus = attendance / lectures * (5 + additionalBonus);

            if (totalBonus > maxBonus)
            {
                maxBonus = totalBonus;
                studentMaxAttendance = attendance;
            }
        }

        if (true)
        {
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentMaxAttendance} lectures.");

        }



    }
}