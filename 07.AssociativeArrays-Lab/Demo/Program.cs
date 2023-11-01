namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

            if (!phoneNumbers.ContainsKey("stosho"))
            {
                phoneNumbers.Add("stosho", "+35988888");
            }

            if (phoneNumbers.ContainsKey("stosho"))
            {
                string phoneNumber = phoneNumbers["stosho"];
                Console.WriteLine(phoneNumber);
            }

            bool isDeleted = phoneNumbers.Remove("stosho");
            Console.WriteLine(isDeleted);
        }
    }
}