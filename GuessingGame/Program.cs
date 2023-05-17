using System;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 1; int upperBound = 25;
            //int winningNumber = new Random().Next(lowerBound, upperBound);
            bool hasWon = false;
            int winningNumber = 5;
            do
            {
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

                }

            } while (!hasWon);
           

            
            
        }
    }
}