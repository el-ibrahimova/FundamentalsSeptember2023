namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                double price = 0;
                double pricePerCapsules = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countOfCapsules = int.Parse(Console.ReadLine());

                price = (days * countOfCapsules) * pricePerCapsules;

                Console.WriteLine($"The price for the coffee is: ${price:f2} ");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}