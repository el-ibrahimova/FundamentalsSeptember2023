namespace _07.CompanyUsers
{
    class Company
    {
        public Company(string name)
        {
            Name = name;
            EmployeeId = new List<string>();
        }
        public string Name { get; set; }
        public List<string> EmployeeId { get; set; }
        
        public override string ToString()
        {
            string result = $"{Name}\n";

            for (int i = 0; i < EmployeeId.Count; i++)
            {
                result += $"-- {EmployeeId[i]}\n";
            }

            return result.Trim();
        }

        public void AddEmployee(string employeeId) // с този метод правим проверка дали вече не съществува такова ID
        {
            if (!EmployeeId.Contains(employeeId))
            {
                EmployeeId.Add(employeeId);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();

            string input;
            while ((input = Console.ReadLine())!= "End")
            {
                string[] arguments = input.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                if (!companies.ContainsKey(companyName))
                {
                    Company company = new Company(companyName);
                    companies.Add(companyName, company);         
                }
                companies[companyName].AddEmployee(employeeId);
            }

            foreach (KeyValuePair<string, Company> pair in companies)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}