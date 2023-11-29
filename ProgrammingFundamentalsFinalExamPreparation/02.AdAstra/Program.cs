using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    public class Product
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return $"Item: {Name}, Best before: {Date}, Nutrition: {Calories}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string text = Console.ReadLine();

            string pattern = @"(\#|\|)(?<name>[A-Za-z ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>(10000|[1-9]\d{0,3}|0))\1";

            foreach (Match match in Regex.Matches(text, pattern))
            {
                Product product = new Product();
                product.Name = match.Groups["name"].Value;
                product.Date = match.Groups["date"].Value;
                product.Calories = int.Parse(match.Groups["calories"].Value);

                products.Add(product);
            }

            int totalCal = 0;
            foreach (var pr in products)
            {
                totalCal += pr.Calories;
            }

            int days = totalCal / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            Console.WriteLine(string.Join("\n", products));
        }
    }
}