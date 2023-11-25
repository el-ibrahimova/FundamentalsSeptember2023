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
            List<Hero> heroes = new List<Hero>();

            int countOfHeroes = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfHeroes; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int hP = int.Parse(input[1]);
                int mP = int.Parse(input[2]);

                Hero hero = new Hero(name, hP, mP);
                heroes.Add(hero);
            }

            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] arguments = commands.Split("-");
                string command = commands[0];

                if (command == "CastSpell")
                {

                }
                else if (command == "TakeDamage")
                {

                }
                else if (command == "Recharge")
                { 
                
                }
                else if (command == "Heal")

            }
        }
    }
}