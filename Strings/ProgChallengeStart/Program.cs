using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int guesses = 0;
            int guess = -2;

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            while (theNumber != guess && guess != -1)
            {
                Console.WriteLine("What's yout guess?");
                string str = Console.ReadLine();
                try { 
                    guess = int.Parse(str);
                    if (guess > theNumber) {
                        Console.WriteLine("Is lower");
                    }
                    else if (guess < theNumber && guess != -1) {
                        Console.WriteLine("Is higher");
                    }
                    else if (guess == theNumber) {
                        Console.WriteLine("You win!");
                    }
                    else {
                        Console.WriteLine("Coward");
                        return;
                    }
                }
                catch {
                    Console.WriteLine("That's not a number.");
                }
                guesses++;
            }
            Console.WriteLine("Guesses so far: " + guesses);
        }
    }
}
