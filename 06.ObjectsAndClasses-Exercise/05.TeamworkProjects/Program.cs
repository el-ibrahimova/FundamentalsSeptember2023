namespace _05.TeamworkProjects
{
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            Name = teamName;
            Creator = creatorName;
        }

        public string Name { set; get; }

        public string Creator { set; get; }
        public List<string> Members { set; get; }

        public override string ToString()
        {
            return $"{Name}/n" +
                $"- {Creator}\n" +
                $"{GetMembersString()}";
        }

        public string GetMembersString()
        {
            Members = Members
                      .OrderBy(name => name)
                      .ToList();

            string result = string.Empty;

            for (int i = 0; i < Members.Count - 1; i++)
            {
                result += $"-- {Members[i]}\n";
            }

            result +=$"-- {Members[Members.Count-1]}"
            
            return result;
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamCommands = Console.ReadLine().Split("-");
                string teamName = teamCommands[1];
                string creatorName = teamCommands[0];

                Team team = new Team(teamName, creatorName);


                Team sameTeamFound = teams.Find(t => t.Name == team.Name); // проверяваме дали вече има създаден отбор със същото име
              
                if (sameTeamFound != null)
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                    continue;
                }

              
                Team sameCreatorFound = teams.Find(t => t.Creator == creatorName); // проверяваме дали създателят на този отбор не е създал преди това и друг отбор
              
                if (sameCreatorFound != null)
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    continue;
                }

                teams.Add(team);
            }

        }
    }
}