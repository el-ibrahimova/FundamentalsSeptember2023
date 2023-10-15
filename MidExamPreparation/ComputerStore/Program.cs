namespace ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalPriceWithTaxes = 0;
            double totalPrice = 0;
            double taxes = 0;

            while (input != "special" && input != "regular")
            {
                double price = double.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else if (price == 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else
                {
                    totalPrice += price;
                    taxes = totalPrice * 0.2;
                    totalPriceWithTaxes = totalPrice + taxes;
                }

                input = Console.ReadLine();
            }

            if (input == "special")
            {
                totalPriceWithTaxes = totalPriceWithTaxes * 0.9;
            }

            Console.WriteLine($"Congratulations you've just bought a new computer!\r\nPrice without taxes: {totalPrice:f2}$\r\nTaxes: {taxes:f2}$\r\n-----------\r\nTotal price: {totalPriceWithTaxes:f2}$");

        }
    }
}