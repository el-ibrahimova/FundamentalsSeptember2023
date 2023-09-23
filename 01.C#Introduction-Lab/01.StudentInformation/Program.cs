namespace _01.StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());

            Console.Write($"Name: {studentName}, Age: {age}, Grade: {average:F2}");
        }
    }
}