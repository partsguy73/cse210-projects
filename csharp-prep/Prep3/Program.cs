using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();
        Console.WriteLine("Welcome to the Magic Number Guessing Game!");
        Console.WriteLine("I've picked a magic number between 1 and 100.");
        Console.WriteLine("Try to guess it!");
        Console.WriteLine();

        // Generate a random magic number between 1 and 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess;
        int guessCount = 0;
        do
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            // Compare Magic Number and Guess
            if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is too high. Please guess again.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low. Please guess again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed it in {guessCount} guesses!");
                break; // Exit the loop when the guess is correct
            }
        } while (true);

        Console.WriteLine();
        Console.WriteLine("Thank you for playing.");
        Console.WriteLine();
    }
}