namespace _01.ActivationKeys_Exam
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



                    case "Slice": break;
                }
            }
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

            activationKey = prefix + middle + suffix;
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


    }
}