namespace _03.SpeedRacing
{

    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsPerKm { get; set; }
        public double TraveledDistance { get; set; }
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




            }
        }
    }
}