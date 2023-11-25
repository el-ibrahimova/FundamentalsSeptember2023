using System.IO;
using System.Text;
using System.Threading.Channels;

namespace _03.HeroesOfCodeAndLogicVII_Exercises
{
    public class Hero
    {
        public Hero(string name, int hP, int mP)
        {
            Name = name;
            Heal(hP);   // Може и само hP, но след като имаме създадените методи, може да ги използваме
            Recharge(mP);   // може и само mP
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public int Recharge(int amountMP)
        {
            int recoveredMP = Math.Min(amountMP, 200 - MP);
            MP += recoveredMP;

            return recoveredMP;
        }

        public int Heal(int amountHP)
        {
            int recoveredHP = Math.Min(amountHP, 100 - HP);
            HP += recoveredHP;

            return recoveredHP;
        }

        public override string ToString()
        {
            StringBuilder heroBuilder = new StringBuilder();
            heroBuilder.AppendLine(Name);
            heroBuilder.AppendLine($"  HP: {HP}");
            heroBuilder.AppendLine($"  MP: {MP}");

            return heroBuilder.ToString();

        }
    }
    internal class Program
    {
        static List<Hero> party = new List<Hero>();
        //изкарваме листа извън Main метода, за да се достъпва и в методите на програмата. Ако не решаваме задачата с методи, това няма да е нужно

        static void Main(string[] args)
        {

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
                    int amountMP = int.Parse(arguments[2]);

                    Recharge(heroName, amountMP);
                }
                else if (command == "Heal")
                {
                    int amountHP = int.Parse(arguments[2]);

                    Heal(heroName, amountHP);
                }
            }

            party.ForEach(h => Console.Write(h));
        }

        static void CastSpell(string heroName, int mPNeeded, string spellName)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
            if (foundHero == null)
            {
                return; // излез от метода
            }

            if (foundHero.MP >= mPNeeded)
            {
                foundHero.MP -= mPNeeded;
                Console.WriteLine($"{foundHero.Name} has successfully cast {spellName} and now has {foundHero.MP} MP!");
            }
            else
            {
                Console.WriteLine($"{foundHero.Name} does not have enough MP to cast {spellName}!");
            }
        }


        static void TakeDamage(string heroName, int damage, string attacker)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);

            if (foundHero == null)
            {
                return; // излез от метода
            }

            foundHero.HP -= damage;

            if (foundHero.HP > 0)
            {
                Console.WriteLine($"{foundHero.Name} was hit for {damage} HP by {attacker} and now has {foundHero.HP} HP left!");
            }
            else
            {
                party.Remove(foundHero);
                Console.WriteLine($"{foundHero.Name} has been killed by {attacker}!");
            }

        }

        static void Recharge(string heroName, int amountMP)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);

            if (foundHero == null)
            {
                return; // излез от метода
            }

            int recovered = foundHero.Recharge(amountMP); // от тук създаваме метод в класа Hero, за да намерим разликата между максималната стойност 200 на MP
            Console.WriteLine($"{foundHero.Name} recharged for {recovered} MP!");
        }

        static void Heal(string heroName, int amountHP)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);


            if (foundHero == null)
            {
                return; // излез от метода
            }

            int recovered = foundHero.Heal(amountHP);
            // от тук по същия начин като в Recharge създаваме метод в класа Hero, за да намерим разликата между максималната стойност 100 на НР

            Console.WriteLine($"{foundHero.Name} healed for {amountHP} HP!");
        }
    }
}