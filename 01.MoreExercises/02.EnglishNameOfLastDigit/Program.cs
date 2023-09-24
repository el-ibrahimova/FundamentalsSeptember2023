namespace _02.EnglishNameOfLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            char lastCharacter = number[number.Length - 1];

            if (lastCharacter == '0') { Console.WriteLine("zero"); }
            else if (lastCharacter == '1') { Console.WriteLine("one"); }
            else if (lastCharacter == '2') { Console.WriteLine("two"); }
            else if (lastCharacter == '3') { Console.WriteLine("three"); }
            else if (lastCharacter == '4') { Console.WriteLine("four"); }
            else if (lastCharacter == '5') { Console.WriteLine("five"); }
            else if (lastCharacter == '6') { Console.WriteLine("six"); }
            else if (lastCharacter == '7') { Console.WriteLine("seven"); }
            else if (lastCharacter == '8') { Console.WriteLine("eight"); }
            else if (lastCharacter == '9') { Console.WriteLine("nine"); }

        }
    }
}