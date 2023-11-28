using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _03.NeedForSpeedIII
{
    public class Car
    {
        public Car(string model, int mileage, int fuelAvailable)
        {
            Model = model;
            Mileage = mileage;
            FuelAvailable = fuelAvailable;
        }

        public string Model { get; set; }
        public int Mileage { get; set; }
        public int FuelAvailable { get; set; }
        public void Drive(int fuelNeeded, int distance)
        {
            if (fuelNeeded <= FuelAvailable)
            {
                Mileage += distance;
                FuelAvailable -= fuelNeeded;
                Console.WriteLine($"{Model} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }

        public void Refuel(string model, int fuel)
        {
            int refuel = Math.Min(fuel, 75-FuelAvailable);
            FuelAvailable += refuel;
            
            Console.WriteLine($"{Model} refueled with {refuel} liters");

        }

        public void Revert(string model, int km)
        {
            Mileage -= km;
            Console.WriteLine($"{Model} mileage decreased by {km} kilometers");
            if (Mileage < 10000)
            {
                Mileage = 10000;
            }
        }
        public override string ToString()
        {
            return $"{Model} -> Mileage: {Mileage} kms, Fuel in the tank: {FuelAvailable} lt.";
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
                string[] carDetails = Console.ReadLine().Split("|");
                string model = carDetails[0];
                int mileage = int.Parse(carDetails[1]);
                int fuelAvailable = int.Parse(carDetails[2]);

                Car car = new Car(model, mileage, fuelAvailable);
                cars.Add(car);
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split(" : ");
                string command = commands[0];
                string model = commands[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(commands[2]);
                    int fuel = int.Parse(commands[3]);
                   
                    Car foundCar = cars.FirstOrDefault(c => c.Model == model);
                    foundCar.Drive(fuel, distance);
                                       
                        if (foundCar.Mileage >= 100000)
                        {
                            cars.Remove(foundCar);
                            Console.WriteLine($"Time to sell the {model}!");
                        }
                }
                else if (command == "Refuel")
                {
                    int fuel = int.Parse(commands[2]);

                    Car foundCar = cars.FirstOrDefault(c => c.Model == model);
                    foundCar.Refuel(model, fuel);

                }
                else // "Revert"
                {
                    int km = int.Parse(commands[2]);
                  
                    Car foundCar = cars.FirstOrDefault(c => c.Model == model);
                    foundCar.Revert(model, km);
                }

            }
            Console.WriteLine(string.Join("\n", cars));
        }
    }
}