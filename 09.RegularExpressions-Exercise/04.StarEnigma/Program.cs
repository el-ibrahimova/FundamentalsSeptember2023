using System.Text.RegularExpressions;
using System.Text;

namespace _04.StarEnigma
{
    public class Message
    {
        public Message(string planetName, uint population, string attackType, uint soldierCount)
        {
            PlanetName = planetName;
            Population = population;
            AttackType = attackType;
            SoldierCount = soldierCount;
        }
        public string PlanetName { get; set; }
        public uint Population { get; set; }
        public string AttackType { get; set; }
        public uint SoldierCount { get; set; }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
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
                
            }
            
        }
    }
}