namespace _03.SpeedRacing
{

    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsPerKm { get; set; }
        public double TraveledDistance { get; set; }

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

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] carCommand = command.Split();
                string drive = "Drive";
                string model = carCommand[1];
                double amountKm = double.Parse(carCommand[2]);
                    cars.Find(x => x.Model == carInfo[0].Move(decimal.Parse(carInfo[2]));
                }

            
        }
    }
}