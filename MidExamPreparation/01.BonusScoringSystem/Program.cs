internal class Program
{
    private static void Main(string[] args)
    {
        int students = int.Parse(Console.ReadLine());
        double lectures = int.Parse(Console.ReadLine());
        int additionalBonus = int.Parse(Console.ReadLine());

        double totalBonus =0;
        double maxBonus = int.MinValue;
        double studentMaxAttendance = 0;

        if (students == 0 || lectures == 0)
        {
            Console.WriteLine($"Max Bonus: 0.");
            Console.WriteLine($"The student has attended 0 lectures.");
            return;
        }

        for (int i = 1; i <= students; i++)
        {
            double attendance = double.Parse(Console.ReadLine());

            totalBonus = (double)attendance / lectures * (5 + additionalBonus);

            if (totalBonus > maxBonus)
            {
                maxBonus = totalBonus;
                studentMaxAttendance = attendance;
            }
        }

        if (true)
        {
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentMaxAttendance} lectures.");

        }



    }
}