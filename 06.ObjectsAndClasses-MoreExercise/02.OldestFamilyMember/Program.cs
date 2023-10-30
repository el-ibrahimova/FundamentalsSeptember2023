namespace _02.OldestFamilyMember
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        public List<Person> familyMembers { get; set; } = new List<Person>();

        public void AddMembers(string[] memberInfo)
        {
            Person newMember = new Person(memberInfo[0], int.Parse(memberInfo[1]));
            familyMembers.Add(newMember);
        }

        public Person GetOldestMember()
        {
            {
                Person oldestPerson = familyMembers.OrderByDescending(x => x.Age).FirstOrDefault();
                return oldestPerson;
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Family family = new Family();

                int numberOfMembers = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberOfMembers; i++)
                {
                    family.AddMembers(Console.ReadLine().Split());
                }

                Person oldest = family.GetOldestMember();

                Console.WriteLine($"{oldest.Name} {oldest.Age}");
            }
        }
    }
}