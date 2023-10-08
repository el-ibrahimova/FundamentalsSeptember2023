namespace _01.DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            switch (input)
            {
                case "int":
                    int number = int.Parse(Console.ReadLine());
                    DataTypeMethod(input, number);
                    break;
                case "real":
                    double number1 = double.Parse(Console.ReadLine());
                    DataTypeMethod(input, number1);
                    break;
                case "string":
                    string str = Console.ReadLine();
                    DataTypeMethod(input, str);
                    break;
            }
        }
        static void DataTypeMethod(string input, int number)
        {
            int result = number * 2;
            Console.WriteLine(result);
        }
        
        static void DataTypeMethod(string input, double number1)
        {
            double result = number1 * 1.5;
            Console.WriteLine($"{result:f2}");
        }

       static void DataTypeMethod(string input, string str)
        {
            Console.WriteLine($"${str}$");
        }

    }
}