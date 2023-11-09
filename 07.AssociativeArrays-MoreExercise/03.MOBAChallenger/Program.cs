namespace _03.MOBAChallenger
{

    public class PlayerPosition
    { 
        public PlayerPosition() 
        {
            Positions = new Dictionary<string, int>();
        }
        public Dictionary<string, int> Positions { get; set; }
        public int TotalSkill { get; set; }


        public void AddPosition(string position, int skill)
        {
            if (!Positions.ContainsKey(position))
            {
                Positions.Add(position, skill);
                TotalSkill += skill;
            }
            else if (Positions.ContainsKey(position) && Positions[position] < skill)
            {
                TotalSkill -= Positions[position];
                TotalSkill += skill;
                Positions[position] = skill;
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, PlayerPosition> players = new Dictionary<string, PlayerPosition>();

            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] commands = input.Split("->", StringSplitOptions.RemoveEmptyEntries);

                if (commands.Length == 3) // {player} -> {position} -> {skill}
                {
                    string player = commands[0];
                    string position = commands[1];
                    int skill = int.Parse(commands[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new PlayerPosition());
                    }
                    players[player].AddPosition(position, skill);
                }
                else  // {player} vs {player}
                {
                    commands = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string player1 = commands[0];
                    string player2 = commands[1];

                    if (players.ContainsKey(player1) && players.ContainsKey(player2) && (HaveCommonPositions(players, player1, player2)))
                    {
                        if (players[player1].TotalSkill > players[player2].TotalSkill)
                        {
                            players.Remove(player2);
                        }
                        else if (players[player1].TotalSkill < players[player2].TotalSkill)
                        {
                            players.Remove(player1);
                        }
                    }

                }
            
            }
            foreach (KeyValuePair<string, PlayerPosition> player in players
                .OrderByDescending(x => x.Value.TotalSkill)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.TotalSkill} skill");
                foreach (KeyValuePair<string, int> position in player
                    .Value
                    .Positions
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"-{position.Key} <::> {position.Value}");
                }
            }
        }

        static bool HaveCommonPositions(Dictionary<string, PlayerPosition> players, string player1, string player2)
        {
            foreach (var position1 in players[player1].Positions)
            {
                foreach (var position2 in players[player2].Positions)
                {
                    if (position1.Key == position2.Key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}