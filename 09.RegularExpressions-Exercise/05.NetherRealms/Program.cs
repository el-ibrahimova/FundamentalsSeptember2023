using System.Text;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    public class Demon
    {
        public Demon(string name, int health, decimal damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public decimal Damage { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Demon> sortedDemons = new List<Demon>();

            string input = Console.ReadLine();
            string[] demonPatterns = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string demonName in demonPatterns)
            {
                int health = CalculateHealth(demonName);
                decimal damage = CalculateDamage(demonName);

                Demon demon = new Demon(demonName, health, damage);
                sortedDemons.Add(demon);
            }

            sortedDemons = sortedDemons.OrderBy(d => d.Name).ToList();

            foreach (Demon demon in sortedDemons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }

        static int CalculateHealth(string demonName)
        {
            int health = 0;

            string wordPattern = @"[^0-9\*\/\+\-\.]"; // All ASCI chars except 0-9\*\/\+\-\.
            MatchCollection matches = Regex.Matches(demonName, wordPattern);

            foreach (Match match in matches)
            {
                health += match.Value[0];
            }

            return health;
        }
        static decimal CalculateDamage(string demonName)
        {
            decimal damage = 0;
            string wordPatternForDamage = @"(?:(?:[-+]*)(?:\d+\.\d+|\d+))"; // all numbers (int/float) with possible prefix +/- ";
            string wordPatternForOperations = @"[\*\/]"; // all * or /

            MatchCollection matchesDamages = Regex.Matches(demonName, wordPatternForDamage);

            foreach (Match match in matchesDamages)
            {
                decimal number = 0;
                decimal.TryParse(match.Value, out number);
                damage += number;
            }

            MatchCollection matches = Regex.Matches(demonName, wordPatternForOperations);
            foreach (Match match in matches)
            {
                switch (match.Value)
                {
                    case "/":
                        damage /= 2;
                        break;
                    case "*":
                        damage *= 2;
                        break;
                }
            }
            return damage;
        }
    }
}