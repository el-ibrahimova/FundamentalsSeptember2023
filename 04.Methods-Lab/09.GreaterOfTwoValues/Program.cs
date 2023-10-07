namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string greaterValue = GetMax(a, b);
                Console.WriteLine(greaterValue);

            }
            else if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int greaterValue = GetMax(a, b);
                Console.WriteLine(greaterValue);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char greaterValue = GetMax(a, b);
                Console.WriteLine(greaterValue);
            }

        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        static char GetMax(char a, char b)
        {
            if (a > b)  //'a' > 'b' => 95 > 96
            {
                return a;
            }
            return b;
        }

        static string GetMax(string a, string b)
        {
            // "Stoyan" > "Pesho"
            int result = a.CompareTo(b);
            // a == b => 0
            // a > b => 1
            // a < b => -1

            if (result > 0) // a>0
            {
                return a;
            }
            return b;
        }
    }
}