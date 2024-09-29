using System;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize random number generator
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to 'Guess the Number'!");
            Console.WriteLine("I have selected a number between 1 and 100.");
            Console.WriteLine("Can you guess what it is?");

            // Game loop
            while (guess != randomNumber)
            {
                Console.Write("Enter your guess: ");

                // Validate user input
                string userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                attempts++; // Increment the attempts count

                // Check the guess
                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number {randomNumber} in {attempts} attempts.");
                }
            }

            Console.WriteLine("Thank you for playing!");
            Console.ReadLine(); // Keep the console window open
        }
    }
}
