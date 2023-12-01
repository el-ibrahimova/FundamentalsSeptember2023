using _04.Snowwhite;

namespace _04.Snowwhite
{
    public class Dwarf
    {
        public Dwarf(string name, string color, int physics)
        {
            Name = name;
            Color = color;
            Physics = physics;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // color, Dwarf
        Dictionary<string, List<Dwarf>> allDwarfs = new Dictionary<string, List<Dwarf>>();
        List<Dwarf> result = new List<Dwarf>();

        string input;
        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            string[] info = input.Split(" <:> ");
            string name = info[0];
            string color = info[1];
            int physics = int.Parse(info[2]);

            if (!allDwarfs.ContainsKey(color))
            {
                allDwarfs[color] = new List<Dwarf>(); // adding like Value in Dictionary
            }

            if (!allDwarfs[color].Any(a => a.Name == name))
            {
                Dwarf dwarf = new Dwarf(name, color, physics);

                allDwarfs[color].Add(dwarf);  // added to Dictionary
                result.Add(dwarf);            // added to List
            }
            else
            {
                var repeatingDwarf = allDwarfs[color].FirstOrDefault(d => d.Name == name);
                repeatingDwarf.Physics = Math.Max(repeatingDwarf.Physics, physics);
            }
        }

        result = result.OrderByDescending(d => d.Physics).ThenByDescending(d => allDwarfs[d.Color].Count).ToList();

        foreach (var dwarf in result)
        {
            Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
        }
    }
}

