using System.IO.Pipes;

namespace _01.CompanyRoster
{
    class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> people = new List<Employee>();
            List<string> departments = new List<string>();


            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split();

                string name = person[0];
                decimal salary = decimal.Parse(person[1]);
                string department = person[2];

                Employee employee = new Employee(name, salary, department);

                people.Add(employee);
                departments.Add(department);
               
            }

            // find department with highest average salary

            string departmentHighestSalary = "";
            decimal highestAverageSalary = decimal.MinValue;

            foreach (string department in departments)
            { 
            decimal averageSalary = people.Where(p=>p.Department == department).Select(p=>p.Salary).Average();

                if (averageSalary > highestAverageSalary)
                {
                    departmentHighestSalary = department;
                    highestAverageSalary = averageSalary;
                }
            }

            // printing results
            Console.WriteLine($"Highest Average Salary: {departmentHighestSalary}");

            foreach (var employee in people.Where(p => p.Department == departmentHighestSalary).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
}