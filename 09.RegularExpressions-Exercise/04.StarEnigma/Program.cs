using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace _04.StarEnigma
{
    public class Message
    {
        public string PlanetName { get; set; }
        public uint Population { get; set; }
        public string AttackType { get; set; }
        public uint SoldierCount { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();

            int messageCount = int.Parse(Console.ReadLine());

            string starPattern = @"[SsTtAaRr]";

            string messagePattern = @"@(?<Planet>[A-Za-z]+)[^\@\-\!\:\>]*:(?<Population>\d+)[^\@\-\!\:\>]*\!(?<AtackType>A|D)\![^\@\-\!\:\>]*\-\>(?<SoldierCount>\d+)";

            for (int i = 0; i < messageCount; i++)
            {
                string encryptMessage = Console.ReadLine();
                int decryptionKey = Regex.Matches(encryptMessage, starPattern).Count;

                StringBuilder messageBuilder = new StringBuilder();

                for (int j = 0; j < encryptMessage.Length; j++)
                {
                    messageBuilder.Append((char)(encryptMessage[j] - decryptionKey));
                }

                string decryptedMessage = messageBuilder.ToString();

                Match match = Regex.Match(decryptedMessage, messagePattern);

                if (!Regex.IsMatch(decryptedMessage, messagePattern)) // проверяваме дали има съвпадения, Инициализиран е, но няма никаква информация в себе си
                {
                    continue;      // ако няма, то продължаваме със следващия ред
                }

                Message message = new Message();

                message.PlanetName = match.Groups["Planet"].Value;
                message.Population = uint.Parse(match.Groups["Population"].Value);
                message.AttackType = match.Groups["AtackType"].Value;
                message.SoldierCount = uint.Parse(match.Groups["SoldierCount"].Value);

                messages.Add(message);
            }

            var filteredMessages = messages
                .Where(m => m.AttackType == "A")
                .OrderBy(m => m.PlanetName)
                .ToList();
           
            Console.WriteLine($"Attacked planets: {filteredMessages.Count}");
            filteredMessages.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

            // горното е кратък запис на това:
            //  foreach (Message message in planets)
            //  {
            //     Console.WriteLine($"-> {message.PlanetName}");
            // }


            filteredMessages = messages
                .Where(m => m.AttackType == "D")
                .OrderBy(m => m.PlanetName)
                .ToList();
           
            Console.WriteLine($"Destroyed planets: {filteredMessages.Count}");
            filteredMessages.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));
        }
    }
}