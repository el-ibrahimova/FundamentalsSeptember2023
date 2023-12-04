namespace Exam_01.StringGame
{

    /*
//Th1s 1s my str1ng!//
Change 1 i
Includes string
End my
Uppercase
FindIndex I
Cut 5 5
Done
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split();
                string command = commands[0];

                if (command == "Change")
                {
                    char ch = char.Parse(commands[1]);
                    char replacement = char.Parse(commands[2]);

                    while (text.Contains(ch))
                    {
                        text = text.Replace(ch, replacement);
                    }                    
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string substring = commands[1];

                    if (text.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                                        
                }
                else if (command == "End")
                {
                    string substring = commands[1];

                    int substringLength = substring.Length;
                    string endOfText = text.Substring(text.Length - substringLength);

                    if (substring == endOfText)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                   
                }
                else if (command == "Uppercase")
                {
                    text = text.ToUpper();                    
                    
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char ch = char.Parse(commands[1]);

                    int index = text.IndexOf(ch);   
                    
                    Console.WriteLine(index);
                }
                else // "Cut"
                {
                    int startIndex = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);

                    string cutText = text.Substring(startIndex, count);
                    text = text.Remove(startIndex, count);
                    Console.WriteLine(cutText);
                }
            }
        }
    }
}