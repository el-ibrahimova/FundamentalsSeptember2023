/*
3
Arnoldii<->4
Woodii<->7
Welwitschia<->2
Rate: Woodii - 10
Rate: Welwitschia - 7
Rate: Arnoldii - 3
Rate: Woodii - 5
Update: Woodii - 5
Reset: Arnoldii
Exhibition 
 */

namespace _03.PlantDiscovery
{
    public class Plant
    {
        public Plant(string name, int rarity)
        {
            Name = name;
            Rarity = rarity;
            Rating = new List<double>();
        }

        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<double> Rating { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] plantsDetails = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string name = plantsDetails[0];
                int rarity = int.Parse(plantsDetails[1]);

                Plant plant = new Plant(name, rarity);

                if (!plants.ContainsKey(name))
                {
                    plants.Add(name, plant);
                }
                else
                {
                    plants[name].Rarity += rarity;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string commandDetails = commands[1];

                string[] details = commandDetails.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string name = details[0];

                if (!plants.ContainsKey(name))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (command == "Rate")
                {
                    double rating = double.Parse(details[1]);
                    plants[name].Rating.Add(rating);
                }
                else if (command == "Update")
                {
                    int newRarity = int.Parse(details[1]);
                    plants[name].Rarity = newRarity;
                }
                else // "Reset"
                {
                    plants[name].Rating.Clear();
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var pl in plants)
            {
                double averageRating = 0;
                if (pl.Value.Rating.Count > 0)
                {
                    averageRating = pl.Value.Rating.Sum() / pl.Value.Rating.Count;
                }
                Console.WriteLine($"- {pl.Key}; Rarity: {pl.Value.Rarity}; Rating: {averageRating:f2}");
            }
        }
    }
}