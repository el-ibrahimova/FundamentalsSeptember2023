namespace _05.ShoppingSpree
{
    public class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<string>();
        }

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> BagOfProducts { get; set; }
    }

    public class Product
    {
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public decimal Cost { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            
            string[] infoForPeople = Console.ReadLine().Split(";");

            for (int i = 0; i < infoForPeople.Length; i++)
            {
                string p1 = infoForPeople[i];
                string[] p1money = p1.Split("=");
                string name = p1money[0];
                decimal money = decimal.Parse(p1money[1]);

                Person person = new Person(name, money);
                persons.Add(person);
            }

            string[] infoForProduct = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < infoForProduct.Length; i++)
            {
                string p1 = infoForProduct[i];
                string[] p1cost = p1.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = p1cost[0];
                decimal cost = decimal.Parse(p1cost[1]);

                Product product = new Product(name, cost);
                products.Add(product);
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split();
                string customer = info[0];
                string productToBuy = info[1];

                var buyer = persons.FirstOrDefault(n => n.Name == customer);

                var purchase = products.FirstOrDefault(p => p.Name == productToBuy);

                if (buyer.Money >= purchase.Cost)
                {
                    buyer.Money -= purchase.Cost;
                    Console.WriteLine($"{customer} bought {productToBuy}");
                    buyer.BagOfProducts.Add(productToBuy);
                }
                else 
                {
                    Console.WriteLine($"{customer} can't afford {productToBuy}");
                }
            }

            foreach (var person in persons)
            {
                if (person.BagOfProducts.Count !=0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}