using System.Collections.Generic;

namespace _03.SpeedRacing
{

    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsPerKm = fuelConsPerKm;
            TraveledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsPerKm { get; set; }
        public double TraveledDistance { get; set; }

        public void Move(decimal km)
        {
            if (FuelConsPerKm * km <= FuelAmount)
            {
                FuelAmount -= FuelConsPerKm * km;
                TraveledDistance += km;
            }
            else Console.WriteLine("Insufficient fuel for the drive")

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TraveledDistance}";
        }


    internal class Program
    {
            static void Main(string[] args)
            {
                int numbersOfCars = int.Parse(Console.ReadLine());

                List<Car> cars = new List<Car>();

                for (int i = 0; i < numbersOfCars; i++)
                {
                    string[] carInfo = Console.ReadLine().Split();

                    Car car = new Car();

                    car.Model = carInfo[0];
                    car.FuelAmount = double.Parse(carInfo[1]);
                    car.FuelConsPerKm = double.Parse(carInfo[2]);
                    car.TraveledDistance = 0;

                    cars.Add(car);
                }

                while (true)
                {
                    string[] data = { Console.ReadLine() };
                    if (data[0] == "End")
                    {
                        break;
                    }
                    data = data[0].Split().ToArray();
                    cars.Find(x => x.Model == data[1]).Move(decimal.Parse(data[2]));
                }
                Console.Write(String.Join("\n", cars));

            }
            
        }
    }
}