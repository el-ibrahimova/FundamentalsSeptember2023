namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }


    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        { 
        
        }
            
        public string FirstName { get; set; }   
        public string LastName { get; set; }    
         public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}