using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerRounds = 0;
            int userRounds = 0;

            for (int i = 0; i < 3; i++)
            {
                int computerWins = 0;
                int userWins = 0;

                Console.WriteLine($"Round {i + 1}");

                for (int ii = 0; ii < 3; ii++)
                {
                    // random computer selection
                    Random random = new Random();
                    int computerSelection = random.Next(3);

                    // user selection
                    Console.WriteLine($"Rock, paper or scissors?");
                    string userInput = Console.ReadLine();

                    // makes user selection lowercase
                    string userSelection = userInput.ToLower();

                    // case 0 == "rock"
                    if (computerSelection == 0 && userSelection == "rock")
                    {
                        Console.WriteLine("Computer threw rock.\nIt's a draw!");
                    }
                    else if (computerSelection == 0 && userSelection == "scissors")
                    {
                        Console.WriteLine("Computer threw rock.\nYou lost!");
                        computerWins++;
                    }
                    else if (computerSelection == 0 && userSelection == "paper")
                    {
                        Console.WriteLine("Computer threw rock.\nYou won!");
                        userWins++;
                    }

                    // case 1 == "paper"
                    if (computerSelection == 1 && userSelection == "rock")
                    {
                        Console.WriteLine("Computer threw paper.\nYou lost!");
                        computerWins++;
                    }
                    else if (computerSelection == 1 && userSelection == "paper")
                    {
                        Console.WriteLine("Computer threw paper.\nIt's a draw!");
                    }
                    else if (computerSelection == 1 && userSelection == "scissors")
                    {
                        Console.WriteLine("Computer threw paper.\nYou won!");
                        userWins++;
                    }

                    // case 2 == "scissors
                    if (computerSelection == 2 && userSelection == "rock")
                    {
                        Console.WriteLine("Computer threw scissors.\nYou won!");
                        userWins++;
                    }
                    else if (computerSelection == 2 && userSelection == "paper")
                    {
                        Console.WriteLine("Computer threw scissors.\nYou lost!");
                        computerWins++;
                    }
                    else if (computerSelection == 2 && userSelection == "scissors")
                    {
                        Console.WriteLine("Computer threw scissors.\nIt's a draw!");
                    }
                }

                if (computerWins == userWins)
                {
                    Console.WriteLine("It's a draw!");
                }
                else if (computerWins > userWins)
                {
                    Console.WriteLine("Computer won this round!");
                    computerRounds++;
                }
                else if (computerWins < userWins)
                {
                    Console.WriteLine("You won this round!");
                    userRounds++;
                }

                Console.ReadLine();
            }

            if (computerRounds > userRounds)
            {
                Console.WriteLine("Computer won the game");
            }
            else if (computerRounds < userRounds)
            {
                Console.WriteLine("You won the game!");
            }
            else if (computerRounds == userRounds)
            {
                Console.WriteLine("The game was a draw...");
            }
        }
    }
}
