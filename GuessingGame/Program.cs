using System;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 1; int upperBound = 5;
            int winningNumber = 1;
            bool hasWon = false;
            bool isGameOver = false;
            bool playAgain = true;
            do
            {
                if(playAgain)
                {
                    winningNumber = new Random().Next(lowerBound, upperBound);
                    playAgain = false;
                    hasWon = false; 
                }
                Console.WriteLine($"Guess a number between {lowerBound} and {upperBound}");

                string playerGuessInput = Console.ReadLine();
                int playerGuessNumber;
                int.TryParse(playerGuessInput, out playerGuessNumber);
                if (!int.TryParse(playerGuessInput, out playerGuessNumber))
                {
                    Console.WriteLine("Invalid Input, Please Enter A Number");
                }
                else
                {
                    if (playerGuessNumber < lowerBound || playerGuessNumber > upperBound)
                    {
                        Console.WriteLine($"Guess is out of bounds.");
                    }
                    else
                    {
                        if (playerGuessNumber == winningNumber)
                        {
                            Console.WriteLine("Congrats you have won!");
                            hasWon = true;
                        }
                        else
                        {
                            Console.WriteLine("WRRROOONNNG!");
                        }
                    }
                    if(hasWon)
                    {
                        do
                        {
                            Console.WriteLine("Play again? y/n");
                            string playAgainInput = Console.ReadLine();
                            if (playAgainInput == "n")
                            {
                                isGameOver = true;
                            }
                            else if (playAgainInput == "y")
                            {
                                playAgain = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                            }
                        }
                        while (!isGameOver && !playAgain);
                    }

                }

            } while (!isGameOver);
            Console.WriteLine("Thanks for playing!");
           

            
            
        }
    }
}