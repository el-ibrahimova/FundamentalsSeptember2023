using System.Text.RegularExpressions;

namespace _03._SoftUniBarIncome
{
    public class Order
    {
        public string Customer { get; set; }
        public string Product { get; set; }

        public int Count { get; set; }
        public decimal Price { get; set; }

        public decimal Total()
        {
            return Count * Price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();

            string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.*\d+)\$";
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    Order order = new Order();

                    order.Customer = match.Groups["name"].Value;
                    order.Product = match.Groups["product"].Value;
                    order.Count = int.Parse(match.Groups["count"].Value);
                    order.Price = decimal.Parse(match.Groups["price"].Value);

                    orders.Add(order);
                }
            }
            
            decimal totalPrice = 0;

            foreach (Order order in orders)
            {
                decimal total = order.Total();
                Console.WriteLine($"{order.Customer}: {order.Product} - {total:f2}");
                totalPrice += order.Total();
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}