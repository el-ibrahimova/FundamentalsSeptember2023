namespace _01.ActivationKeys_Exercises
{
    internal class Program
    {
        static string activationKey;
        // пищшем го като пропърти на класа Program, за да е видимо във всички методи (за да не се повтаря като променлива и аргумент в методите на класа)

        static void Main(string[] args)
        {
            activationKey = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] arguments = input.Split(">>>");
                switch (arguments[0])
                {
                    case "Contains":
                        string substring = arguments[1];
                        // така трябваше да го запишем, ако не бяхме изнесли activationKey като пропърти на класа Program
                        // activationKey = Contains(activationKey, substring);

                        Contains(substring);
                        break;

                    case "Flip":
                        int startIndex = int.Parse(arguments[2]);
                        int endIndex = int.Parse(arguments[3]);

                        if (arguments[1] == "Upper")
                        {
                            FlipUpper(startIndex, endIndex);
                        }
                        else if (arguments[1] == "Lower")
                        {
                            FlipLower(startIndex, endIndex);
                        }
                        break;

                    case "Slice":
                        int firstIndex = int.Parse(arguments[1]);
                        int secondIndex = int.Parse(arguments[2]);

                        Slice(firstIndex, secondIndex);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        static void Contains(string substring)
        {
            if (activationKey.Contains(substring))
            {
                Console.WriteLine($"{activationKey} contains {substring}");
            }
            else
            {
                Console.WriteLine($"Substring not found!");
            }
        }
        static void FlipUpper(int start, int end)
        {
            string prefix = activationKey.Substring(0, start);
            string middle = activationKey.Substring(start, end - start).ToUpper(); // директно изпълняваме командата за уголемяване
            string suffix = activationKey.Substring(end); // от индекс end до края на стринга

            activationKey = prefix + middle + suffix; // презаписваме новата стойност на activationKey
            Console.WriteLine(activationKey);
        }
        static void FlipLower(int start, int end)
        {
            string prefix = activationKey.Substring(0, start);
            string middle = activationKey.Substring(start, end - start).ToLower(); // директно изпълняваме командата за намаляване 
            string suffix = activationKey.Substring(end); // от индекс end до края на стринга

            activationKey = prefix + middle + suffix;
            Console.WriteLine(activationKey);
        }
        static void Slice(int firstIndex, int secondIndex)
        {
            string firstPart = activationKey.Substring(0, firstIndex);
            string secondPart = activationKey.Substring(secondIndex);

            // стринга по средата не се записва в новия стринг => той е изтрит

            activationKey = firstPart + secondPart;

            // задачата може да се реши и така
            // activationKey.Remove(firstIndex, secondIndex - firstIndex); 

            Console.WriteLine(activationKey);
        }
    }
}
