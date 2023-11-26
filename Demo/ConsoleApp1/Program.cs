namespace ConsoleApp1  // Raw Data - More exercises Objects and classes
{
    public class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }

    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }
        public string Type { get; set; }
    }

    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int countOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];

                Car car = new Car(model, new Engine(speed, power), new Cargo(weight, type));
                cars.Add(car);
                
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (Car car in cars.Where(c => c.Cargo.Type == "fragile" && c.Cargo.Weight < 1000))
                {
                    Console.WriteLine(car.Model);
                }

            }
            else if (command == "flamable")
            {
                foreach (Car car in cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}