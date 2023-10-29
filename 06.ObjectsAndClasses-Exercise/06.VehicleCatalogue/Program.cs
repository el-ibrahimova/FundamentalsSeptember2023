using System.Threading.Channels;
using System.Xml.Linq;

namespace _06.VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, string horsePower)
        {
            Type = type == "car" ? "Car" : "Truck";
            Model = model;
            Color = color;
            HorsePower = double.Parse(horsePower);
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {HorsePower}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {

                string[] arguments = command.Split();

                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                string horsePower = arguments[3];

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                catalogue.Add(vehicle);
            }

            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    break;
                }

                Console.WriteLine(catalogue.Find(x => x.Model == model));
            }


            var onlyCars = catalogue.Where(x => x.Type == "Car").ToList();
            var onlyTrucks = catalogue.Where(x => x.Type == "Truck").ToList();

            double totalCarsHorsepower = 0;
            double totalTrucksHorsepower = 0;

            foreach (var car in onlyCars)
            {
                totalCarsHorsepower += car.HorsePower;
            }

            foreach (var truck in onlyTrucks)
            {
                totalTrucksHorsepower += truck.HorsePower;
            }

            double averageCarsHorsepower = totalCarsHorsepower / onlyCars.Count;
            double averageTrucksHorsepower = totalTrucksHorsepower / onlyTrucks.Count;

            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}

