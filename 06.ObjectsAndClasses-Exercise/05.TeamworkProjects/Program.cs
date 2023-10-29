namespace _05.TeamworkProjects
{
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            Name = teamName;
            Creator = creatorName;
            Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"{Name}\n" +
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

            result += $"-- {Members[Members.Count - 1]}";
            
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
                Team team = new Team(teamCommands[1], teamCommands[0]); // създаваме обект Отбор


                Team sameTeamFound = teams.Find(t => t.Name == team.Name); // проверяваме дали вече има създаден отбор със същото име
              
                if (sameTeamFound != null)
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                    continue;
                }

              
                Team sameCreatorFound = teams.Find(t => t.Creator == team.Creator); // проверяваме дали създателят на този отбор не е създал преди това и друг отбор
              
                if (sameCreatorFound != null)
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    continue;
                }

                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");

            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");

                string joinerName = arguments[0];
                string teamName = arguments[1];

                bool hasAnyTeamWithSameName = teams.Any(t => t.Name == teamName);
                //има ли поне един отбор, който е еднакъв с този, който са ни дали от конзолата

                if (hasAnyTeamWithSameName == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                // търсим дали има един човек в два отбора, като създател или член
                if (teams.Any(team => team.Creator == joinerName) ||
                   (teams.Any(team => team.Members.Contains(joinerName))))
                {
                    Console.WriteLine($"Member {joinerName} cannot join team {teamName}!");
                    continue;
                }

                //  след всички проверки,и ако той е валиден, добавяме човека в отбора, към който иска да се присъедини

                 teams.Find(t => t.Name == teamName).Members.Add(joinerName);
            }

            List<Team> leftTeams = teams.Where(t => t.Members.Count > 0).ToList();

            List<Team> orderedTeams = leftTeams
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            orderedTeams.ForEach(team => Console.WriteLine(team));

          
            List<Team> disbandTeams = teams.Where(t => t.Members.Count == 0).ToList();
            Console.WriteLine("Teams to disband:");

            orderedTeams = disbandTeams.OrderBy(x => x.Name).ToList();
            orderedTeams.ForEach(team => Console.WriteLine(team.Name));
        }
    }
}