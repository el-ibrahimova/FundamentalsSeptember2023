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
                            // пример: exchange 1
                            int index = int.Parse(arguments[1]);
                            // разделяме масива и разменяме местата според подадения индекс
                           numbers = Exchange(numbers, index); // създаваме метод, в който ще изпълняваме командата за смяна на индексите
                            break;

                        case "max":
                            // пример: max odd
                            string maxType = arguments[1];
                            // от тук вземаме дали търсим четно или нечетно число
                            PrintMaxNumber(numbers, maxType);  // създаваме метод, който търси max/min odd/even
                            break;

                        case "min":
                            //пример: min even
                            string minType = arguments[1];
                            // от тук вземаме дали търсим четно или нечетно число
                            PrintMinNumber(numbers, minType);  // създаваме метод, който търси max/min odd/even
                            break;

                        case "first":
                            // пример: first 2 odd
                            int firstLength = int.Parse(arguments[1]); //парсваме втория индекс =>2
                            string firstType = arguments[2]; // взимаме третия индекс => odd
                            PrintFirstElements(numbers, firstLength, firstType); // създаваме метод, който принтира първите n елементи
                            break;

                        case "last":
                            // пример: last 2 odd
                            int lastLength = int.Parse(arguments[1]); //парсваме втория индекс =>2
                            string lastType = arguments[2]; // взимаме третия индекс => odd
                            PrintLastElements(numbers, lastLength, lastType); // създаваме метод, който принтира последните n елементи
                            break;
                    }
                }

                
            }
            // END while
           
            Console.WriteLine($"[{string.Join(",",numbers)}]");

        }

        static int [] Exchange(int[] numbers, int index)
        {

            if (CheckForOutOfBound(numbers, index)) //масив, в който проверяваме дали индекса не е извън от границите
            {
                Console.WriteLine("Invalid index");
                return numbers; // връщаме същия масив, защото метода ни е от тип масив
            }


            int[] changedArray = new int[numbers.Length];

            //  0  1  2  3  4 - индекси
            // [1, 3, 5, 7, 9]
            // [0, 0, 0, 0, 0]   => [0, 0, 0, 1, 3]  => [5, 7, 9, 1, 3]

            int changedArrayIndex = 0;
            for (int i = index +1; i < numbers.Length; i++)
            {
                // int i = index +1 => по условие се вземат индексите след дадения
                changedArray[changedArrayIndex] = numbers[i];
                changedArrayIndex++;
            }
            // след този цикъл масива има вида changedArray [5, 7, 9, 0, 0] при подаден индекс 2

            for (int i = 0; i < index; i++)
            {
                changedArray[changedArrayIndex] = numbers[i];
                changedArrayIndex++;
            }

            // => numbers = [1,3,5,7,9]
            // => changedArray = [5, 7, 9, 1, 3]
            // за да има numbers[] новото съдържание правим следното:
            numbers = changedArray;
            // до тук новия масив съществува само в този метод.
            // За да го подменим в цялата програма правим следното:
            // => връщаме масив с return и променяме типа на масива от void на int []
            return changedArray; 
        }

        static void PrintMaxNumber(int[] numbers, string type)
        // type = "even" || "odd"
        {
            int maxIndex = -1; // границите на масива са от 0 до numbers.Length-1. За да сме сигурни, че индекса е Min => -1
            int maxNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsOddOrEven(numbers, type, i))
                {
                    if (numbers[i] >= maxNumber)
                    {
                        maxNumber = numbers[i];
                        maxIndex = i;
                    }
                }
            }
            PrintIndex(maxIndex);
        }

        private static bool IsOddOrEven(int[] numbers, string type, int i)
        {
            return (type == "odd" && numbers[i] % 2 != 0) ||
                                (type == "even" && numbers[i] % 2 == 0);
        }


        static void PrintMinNumber(int[] numbers, string type)
        // type = "even" || "odd"
        {

        }
        
        static void PrintFirstElements(int[] numbers, int length, string type)
        {
           
        } 
        
        static void PrintLastElements(int[] numbers, int length, string type)
        {
            
        }

        static bool CheckForOutOfBound(int[] numbers, int index)
        {
            return index < 0 || index >= numbers.Length;
        }

        static void PrintIndex(int maxIndex)
        {
            if (maxIndex != -1) // не е намерен мах индекс =>остава си първоначалната ст-ст
            {
                 Console.WriteLine(maxIndex);
            }
            else
            {
               Console.WriteLine("No matches");
            }
        }








    }
}