using System.Xml.Linq;

namespace Exam_03.HeroRecruitment
{
    /*
Enroll Stefan 
Enroll Peter
Enroll Stefan
Learn Stefan ItShouldWork
Learn John ItShouldNotWork
Unlearn George Dispel
Unlearn Stefan ItShouldWork
End   
     */

    public class Hero
    {
        public Hero(string name)
        {
            Name = name;
            Spell = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Spell { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();
            
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                string command = commands[0];
                string heroName = commands[1];

                if (command == "Enroll")
                {
                    var heroExist = heroes.FirstOrDefault(h => h.Name == heroName);
                    if (heroExist != null)
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                    else 
                    {
                        Hero hero = new Hero(heroName);                        
                        heroes.Add(hero);
                    }
                }
                else if (command == "Learn")
                {
                    string spellName = commands[2];

                    var heroExist = heroes.FirstOrDefault(h => h.Name == heroName);
                    if (heroExist != null)
                    {
                        if (heroExist.Spell.Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                        else
                        {
                            heroExist.Spell.Add(spellName);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
                else // "Unlearn"
                {
                    string spellName = commands[2];

                    var heroExist = heroes.FirstOrDefault(h => h.Name == heroName);
                    if (heroExist != null)
                    {
                        if (heroExist.Spell.Contains(spellName))
                        {
                            heroExist.Spell.Remove(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
            }

            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Name}: {string.Join(", ",hero.Spell)}");
            }
        }
    }
}