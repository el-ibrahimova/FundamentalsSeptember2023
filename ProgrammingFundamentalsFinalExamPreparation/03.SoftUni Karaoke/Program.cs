namespace _03.SoftUni_Karaoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // participant name, awards
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            List<string> participants = Console.ReadLine().Split(", ").ToList();
            List<string> availableSongs = Console.ReadLine().Split(", ").ToList();

            string input;
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] performance = input.Split(", ");
                string participantName = performance[0];
                string song = performance[1];
                string award = performance[2];

                if (!result.ContainsKey(participantName))
                {
                    if (participants.Contains(participantName))
                    {
                        if (availableSongs.Contains(song))
                        {
                            result.Add(participantName, new List<string>());
                            result[participantName].Add(award);
                        }
                    }
                }
                else
                {
                    if (availableSongs.Contains(song))
                    {
                        if (!result[participantName].Contains(award))
                        {
                            result[participantName].Add(award);
                        }
                    }
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var part in result.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    if (part.Value.Count != 0)
                    {
                        Console.WriteLine($"{part.Key}: {part.Value.Count} awards");

                        foreach (var award in part.Value)
                        {
                            Console.WriteLine($"--{award}");
                        }
                    }
                }
            }
        }
    }
}