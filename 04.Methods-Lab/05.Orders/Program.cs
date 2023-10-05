namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            TotalPriceOfProduct(product, quantity);
        }

       static void TotalPriceOfProduct(string product, int quantity)
        {
            double totalPrice=0;
            switch (product)
            {
                case "coffee":
                    totalPrice = quantity * 1.5;
                    break;
                case "water":
                    totalPrice = quantity * 1;
                    break;
                case "coke":
                    totalPrice = quantity * 1.4;
                    break;
                case "snacks":
                    totalPrice = quantity * 2;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}