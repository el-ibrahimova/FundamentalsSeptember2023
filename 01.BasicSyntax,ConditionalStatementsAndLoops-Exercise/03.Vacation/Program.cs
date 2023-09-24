namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 8.45; break;
                    case "Saturday": price = 9.80; break;
                    case "Sunday": price = 10.46; break;
                }
                totalPrice = price * countOfPeople;

                if (countOfPeople >= 30)
                {
                    totalPrice = totalPrice * 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 10.90; break;
                    case "Saturday": price = 15.60; break;
                    case "Sunday": price = 16; break;
                }
                totalPrice = price * countOfPeople;

                if (countOfPeople >= 100)
                {
                    totalPrice = (countOfPeople - 10) * price; ;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 15; break;
                    case "Saturday": price = 20; break;
                    case "Sunday": price = 22.50; break;
                }
                totalPrice = price * countOfPeople;

                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    totalPrice = 0.95 * totalPrice;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}