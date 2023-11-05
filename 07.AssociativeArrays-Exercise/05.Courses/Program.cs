namespace _05.Courses
{
    class Course
    {
        public Course(string name)
        {
            Name = name;
            StudentNames = new List<string>();
        }

        public string Name;
        public List<string> StudentNames;

        public override string ToString()
        {
            string result = $"{Name}: {StudentNames.Count}\n";
            for (int i = 0; i < StudentNames.Count; i++)
            {
                result += $"-- {StudentNames[i]}\n";
            }

            return result.Trim(); // премахва празни редове => след последния човек не е нужно да има нов ред
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            { 
            string[] arguments = input.Split(" : ");
                string courseName = arguments[0];
                string studentName = arguments[1];

                if (!courses.ContainsKey(courseName))
                {
                    Course course = new Course(courseName);
                    courses.Add(course.Name, course);
                }
             
                // Course foundCourse = courses[courseName];
                // List <string> courseStudents = foundCourse.StudentNames;
                // courseStudents.Add(studentName);
                 
                courses[courseName].StudentNames.Add(studentName);            
            }

            foreach (KeyValuePair<string, Course> coursesPair in courses)
            {
                Console.WriteLine(coursesPair.Value); ;
            }
        }
    }
}