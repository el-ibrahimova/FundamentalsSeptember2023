using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public uint Distance { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Add participants

            List<string> participantNames = Console.ReadLine().Split(", ").ToList();
            List<Participant> participants = new List<Participant>();


            foreach (string name in participantNames)
            {
                Participant participant = new Participant(name);
                participants.Add(participant);
            }

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string lettersPattern = @"[A-Za-z]"; // Името на участника

                StringBuilder nameBuilder = new StringBuilder();
                foreach (Match match in Regex.Matches(input, lettersPattern))
                {
                    nameBuilder.Append(match.Value);
                }

                string participantName = nameBuilder.ToString();

                uint distance = 0;
                string digitsPattern = @"\d"; // точките на участника
                foreach (Match match in Regex.Matches(input, digitsPattern))
                {
                    distance += uint.Parse(match.Value);
                }


                Participant foundParticipant = participants.FirstOrDefault(p => p.Name == participantName);
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }

                foreach (Participant participant in participants)
                {
                    Console.WriteLine(participant.Distance);
            }
        }
    }
}