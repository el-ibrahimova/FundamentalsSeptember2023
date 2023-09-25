using System.Drawing;

namespace PracticalProject_Rock_Paper_Scissor
{
    internal class RockPaperScissor
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart:
            Console.ForegroundColor = ConsoleColor.Yellow;  
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            
            string playerMove = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1: computerMove = "Rock"; break;
                case 2: computerMove = "Paper"; break;
                case 3: computerMove = "Scissors"; break;
            }
            Console.WriteLine($"The computer choose {computerMove}");

            if ((playerMove == Rock && computerMove == Scissors) ||
               (playerMove == Paper && computerMove == Rock) ||
               (playerMove == Scissors && computerMove == Paper))
            {
                Console.WriteLine("You win.");
            }
            else if ((playerMove == Rock && computerMove == Paper) ||
               (playerMove == Paper && computerMove == Scissors) ||
               (playerMove == Scissors && computerMove == Rock))
            {
                Console.WriteLine("You lose.");
            }
            else 
            {
                Console.WriteLine("This game was a draw.");
            }

            Console.Write("Type [yes] to Play Again or [no] to quit: ");
            string playerChoice = Console.ReadLine();

            if (playerChoice == "no")
            {
                Console.WriteLine("Thank you for playing!");
            }
            else if (playerChoice == "yes")
                {
                goto ParameterizedThreadStart;
            }

            


        }
    }
}