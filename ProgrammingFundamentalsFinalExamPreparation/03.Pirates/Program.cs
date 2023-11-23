namespace _03.Pirates
{
    public class City
    {
        public string Name { get; set; }
        public int Populaion { get; set; }
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

        }
    }
}
}