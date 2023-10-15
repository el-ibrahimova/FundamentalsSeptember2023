namespace SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());

            int timeNeeded = 0;
            int maxStudentForHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;


            if (studentCount % maxStudentForHour == 0)
            {
                timeNeeded = studentCount / maxStudentForHour;
            }
            else if (studentCount % maxStudentForHour != 0)
            {
                timeNeeded = studentCount / maxStudentForHour + 1;
            }

            if (timeNeeded > 3 && timeNeeded % 3 == 0)
            {
                timeNeeded += timeNeeded / 3 - 1;
            }
            else if (timeNeeded > 3)
            {
                timeNeeded += timeNeeded / 3;
            }

            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}