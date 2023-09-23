namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine()); 
            int capacityOfElevator = int.Parse(Console.ReadLine()); 

            int courses = (int)Math.Ceiling((double)numberOfPeople / capacityOfElevator);
            Console.WriteLine(courses);
        }
    }
}