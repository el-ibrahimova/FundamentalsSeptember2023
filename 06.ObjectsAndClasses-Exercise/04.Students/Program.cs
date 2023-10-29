namespace _04.Students
{
    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentArgs = Console.ReadLine()
                     .Split()
                     .ToArray();

                Student student = new Student();

                student.FirstName = studentArgs[0];
                student.LastName = studentArgs[1];
                student.Grade = float.Parse(studentArgs[2]);

                students.Add(student);
            }

            List<Student> orderedStudents = students
                                            .OrderByDescending(student => student.Grade)
                                            .ToList();

            Console.WriteLine(string.Join("\n", orderedStudents));

        }
    }
}