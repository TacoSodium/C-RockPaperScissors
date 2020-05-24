using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 = "rock"
            // 1 = "paper"
            // 2 = "scissors

            Random random = new Random();
            int computerSelection = random.Next(3);

            Console.WriteLine($"Rock, paper or scissors?");
            string userInput = Console.ReadLine();

            string userSelection = userInput.ToLower();

            if (computerSelection == 0 && userSelection == "rock") {
                Console.WriteLine("Computer threw rock.\nIt's a draw!");
            } else if (computerSelection == 0 && userSelection == "scissors") {
                Console.WriteLine("Computer threw rock.\nYou lost!");
            } else if (computerSelection == 0 && userSelection == "paper") {
                Console.WriteLine("Computer threw rock.\nYou won!");
            }

            if (computerSelection == 1 && userSelection == "rock") {
                Console.WriteLine("Computer threw paper.\nYou lost!");
            } else if (computerSelection == 1 && userSelection == "paper") {
                Console.WriteLine("Computer threw paper.\nIt's a draw!");
            } else if (computerSelection == 1 && userSelection == "scissors") {
                Console.WriteLine("Computer threw paper.\nYou won!");
            }

            if (computerSelection == 2 && userSelection == "rock") {
                Console.WriteLine("Computer threw scissors.\nYou won!");
            } else if (computerSelection == 2 && userSelection == "paper") {
                Console.WriteLine("Computer threw scissors.\nYou lost!");
            } else if (computerSelection == 2 && userSelection == "scissors") {
                Console.WriteLine("Computer threw scissors.\nIt's a draw!");
            }
        }
    }
}
