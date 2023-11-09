using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> contest = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, int>> student = new Dictionary<string, Dictionary<string, int>>();

        string input;
        while ((input = Console.ReadLine()) != "end of contests")
        {
            string[] arguments = input.Split(":").ToArray();
            string contestName = arguments[0];
            string password = arguments[1];

            if (!contest.ContainsKey(contestName))
            {
                contest.Add(contestName, password);
            }
        }

        string input2;
        while ((input2 = Console.ReadLine()) != "end of submissions")
        {
            string[] commands = input2.Split("=>");
            string contestName = commands[0];
            string password = commands[1];
            string username = commands[2];
            int points = int.Parse(commands[3]);

            if (contest.ContainsKey(contestName) && contest[contestName] == password)
            {
                if (!student.ContainsKey(username))
                {
                    student.Add(username, new Dictionary<string, int>());
                    student[username].Add(contestName, points);
                }
                else
                {
                    if (!student[username].ContainsKey(contestName))
                    {
                        student[username].Add(contestName, points);
                    }
                    else
                    {
                        if (student[username][contestName] < points)
                        {
                            student[username][contestName] = points;
                        }
                    }
                }
                
            }
            commands = input2.Split("=>");
        }

            string bestStudent = "";
            int highPoints = 0;

            foreach (var name in student)
            {
                int totalPoints = 0;

                foreach (var course in name.Value)
                {
                    totalPoints += course.Value;
                }

                if (totalPoints > highPoints)
                {
                    bestStudent = name.Key;
                    highPoints = totalPoints;
                }
            }
        
        Console.WriteLine($"Best candidate is {bestStudent} with total {highPoints} points.");

        student = student
            .OrderBy(x => x.Key)
            .ToDictionary(k => k.Key, v => v.Value);

        Console.WriteLine("Ranking: ");

        foreach (var name in student)
        {
            Console.WriteLine(name.Key);
            foreach (var course in name.Value.OrderByDescending(v => v.Value))
            {
                Console.WriteLine($"#  {course.Key} -> {course.Value}");
            }
        }
    }
}
