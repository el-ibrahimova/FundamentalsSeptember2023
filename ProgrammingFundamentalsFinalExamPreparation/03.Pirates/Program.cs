namespace _03.Pirates
{
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            string line;
            while ((line = Console.ReadLine()) != "Sail")
            {
                string[] tokens = line.Split("||");
                string cityName = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                City city = cities.FirstOrDefault(x => x.Name == cityName); //така правим проверка дали в листа имаме град с такова име 
                // => връща null, ako няма такава стойност, и името на града, ако има

                if (city is not null)
                {
                    city.Populaion += population;
                    city.Gold += gold;
                    continue;
                }

                cities.Add(new City
                {
                    Name = cityName,
                    Populaion = population,
                    Gold = gold
                });
            }

            line = string.Empty; // занулаваме стринга line
            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split("=>");
                string command = tokens[0];
                string cityName = tokens[1];

                City city = cities.FirstOrDefault(x => x.Name == cityName);

                if (command == "Plunder")
                {
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);

                    city.Population -= people;
                    city.Gold -= gold;

                    Console.WriteLine($"{city.Name} plundered! {gold} gold stolen, {people} citizens killed.");


                    if (city.Population <= 0 || city.Gold <= 0)
                    {
                        cities.Remove(city);

                        Console.WriteLine($"{city.Name} has been wiped off the map!");
                    }
                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(tokens[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue; // ignore command
                    }

                    city.Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {city.Name} now has {city.Gold} gold.");

                }
            }

            if (cities.Count == 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }

            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

            foreach (City city in cities)
            {
                Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
            }

        }
    }
}
