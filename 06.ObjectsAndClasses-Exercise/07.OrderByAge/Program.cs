using System.Drawing;
using System.Reflection;

namespace _07.OrderByAge
{
    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID:{ID} is {Age} years old.";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
           List <Person> people = new List <Person> ();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                
                string name = arguments[0];
                string iD = arguments[1];
                int age = int.Parse(arguments[2]);

                if (people.Any(p => p.ID == iD))
                {
                    name = arguments[0];
                    age = int.Parse(arguments[2]);
                }
                
                Person persons = new Person(name, iD, age);

                people.Add(persons);            
            }

            List<Person> ordered = people
                .OrderBy(t => t.Age)
                .ToList();

            ordered.ForEach(people => Console.WriteLine(people));
        }
    }
}