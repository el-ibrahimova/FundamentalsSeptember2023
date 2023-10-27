namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] vehicleInfo = input.Split('/');
                string vehicleType = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]); // horsePower or Weight

                if (vehicleType == "Truck")
                {
                    Truck truck = new Truck(brand, model, value);
                    catalog.Trucks.Add(truck);
                }
                else 
                {
                    Car car = new Car(brand, model, value);
                    catalog.Cars.Add(car);
                }

                input = Console.ReadLine();
            }

            foreach (var car in catalog.Cars
                .OrderBy(x=>x.Brand))    // сортираме колите по техния бранд
            { 
            
            }

            foreach (var truck in catalog.Trucks)
            { 
            
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }

    public class Catalog
    { 
    public List<Car> Cars { get; set; }
    
    public List<Truck> Trucks { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

}