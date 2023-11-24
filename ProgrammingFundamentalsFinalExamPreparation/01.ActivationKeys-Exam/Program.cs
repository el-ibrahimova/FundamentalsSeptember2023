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
                        if (arguments[1] == "Upper")
                        {

                        }
                        else if (arguments[1] == "Lower")
                        { 
                        
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
    }
}