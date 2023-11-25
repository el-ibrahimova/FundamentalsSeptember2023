using System.IO;

namespace _03.HeroesOfCodeAndLogicVII_Exercises
{
    public class Hero
    {
        public Hero(string name, int hP, int mP)
        {
            Name = name;
            HP = hP;
            MP = mP;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hero> party = new List<Hero>();

            int countOfHeroes = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfHeroes; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int hP = int.Parse(input[1]);
                int mP = int.Parse(input[2]);

                Hero hero = new Hero(name, hP, mP);
                party.Add(hero);
            }

            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] arguments = commands.Split(" - ");
                string command = arguments[0];
                string heroName = arguments[1];

                if (command == "CastSpell")
                {
                    int mPNeeded = int.Parse(arguments[2]);
                    string spellName = arguments[3];

                    CastSpell(heroName, mPNeeded, spellName);

                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(arguments[2]);
                    string attacker = arguments[3];

                    TakeDamage(heroName, damage, attacker);
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(arguments[2]);

                    Recharge(heroName, amount);
                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(arguments[2]);

                    Heal(heroName, amount);
                }

            }
        }

        

        static void CastSpell(string heroName, int mPNeeded, string spellName)
        {
            foreach (var hero in party)
            {
                if (hero.MP >= mPNeeded)
                    hero.MP -= mPNeeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {hero.MP} MP!");
            }
        }

        static void TakeDamage(string heroName, int damage, string attacker)
        {
            throw new NotImplementedException();
        }
        static void Recharge(string heroName, int amount)
        {
            throw new NotImplementedException();
        }
        
        private static void Heal(string heroName, int amount)
        {
            throw new NotImplementedException();
        }
    }
}