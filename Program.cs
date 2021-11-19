using System;
using System.Collections.Generic;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose Difficulty: 1 -easy, 2 -medium, 3 -hard, 4 -hardest, 5 -cheater");
            var difficulty = int.Parse(Console.ReadLine());
            int numberOfGuesses = new int[] { 8, 6, 4, 2, 1 }[difficulty - 1];

            int secretNumber = new Random().Next(1, 101);

            while (difficulty == 5 || numberOfGuesses > 0)
            {
                string guessesLeft = difficulty == 5 ? "INFINITE!" : numberOfGuesses.ToString();
                Console.WriteLine("Guess the secret number!");
                Console.Write($"Your Guess (Guesses left: {guessesLeft}): ");
                var input = int.Parse(Console.ReadLine());

                if (secretNumber == input)
                {
                    Console.WriteLine("CORRECT!");
                    break;
                }
                else if (secretNumber > input)
                {
                    Console.WriteLine("Your guess is too low!");
                }
                else
                {
                    Console.WriteLine("Your guess is too high!");
                }
            };
        }
    }
}