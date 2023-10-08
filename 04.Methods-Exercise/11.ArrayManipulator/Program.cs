using System.Data;
using System.Globalization;
using System.Security.Authentication;

namespace _11.ArrayManipulator
{
    /* 
       1 3 5 7 9
    --- [1,3,5,7,9]
       exchange 1
    ----[5,7,9,1,3]
       max odd
    ---2
       min even
    ---No matches
       first 2 odd
    ---[5 ,7]
       last 2 even
    ---[]
       exchange 3
    ---[3,5,7,9,1]
       end
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end") 
                //докато от конзолата не дойде команда "end" правим следното:
                //=>прочитаме какви са командите ни, като ги презентираме като наниз от стрингове

                {
                string[] arguments = command.Split(); // правим командата като стринг от низове
                {
                    switch (arguments[0]) // четем първия низ от командата
                    {
                        case "exchange":
                            int index = int.Parse(arguments[1]);
                            // разделяме масива и разменяме местата според подадения индекс
                            Exchange(numbers, index); // създаваме метод, в който ще изпълняваме командата за смяна на индексите
                            break;

                        case "max":
                            string maxType = arguments[1];
                            // от тук вземаме дали търсим четно или нечетно число
                            PrintMaxNumber(numbers, maxType);  // създаваме метод, който търси max/min odd/even
                            break;

                        case "min":
                            string minType = arguments[1];
                            // от тук вземаме дали търсим четно или нечетно число
                            PrintMinNumber(numbers, minType);  // създаваме метод, който търси max/min odd/even
                            break;

                        case "first":
                            // пример: first 2 odd
                            int length = int.Parse(arguments[1]); //парсваме втория индекс =>2
                            string firstType = arguments[2]; // взимаме третия индекс => odd
                            PrintFirstElements(numbers, length, firstType);

                            break;
                        case "last": break;
                                
                    }
                }


            }

        }

        private static void PrintFirstElements(int[] numbers, int length, string firstType)
        {
            PrintFirstElements(numbers, length, firstType);
        }

        static void PrintMinNumber(int[] numbers, string type)
        // type = "even" || "odd"
        {

        }

        static void PrintMaxNumber(int[]numbers, string type) 
            // type = "even" || "odd"
        {
           
        }

        static void Exchange(int[] numbers, int index)
        {
           
        }
    }
}