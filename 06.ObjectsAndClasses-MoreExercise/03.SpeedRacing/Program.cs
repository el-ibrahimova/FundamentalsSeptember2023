namespace _03.SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            TraveledDistance =0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TraveledDistance { get; set; }

        public void MoveCar(double km)
        {
            if (FuelConsumptionPerKm * km <= FuelAmount)
            {
                FuelAmount -= FuelConsumptionPerKm * km;
                TraveledDistance += km;
            }
            else 
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TraveledDistance}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKm = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKm);
                cars.Add(car);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                string carModel = arguments[1];
                double amountOfKm = double.Parse(arguments[2]);

                cars.Find(c=>c.Model==carModel).MoveCar(amountOfKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car}");
            }
        }
    }
}