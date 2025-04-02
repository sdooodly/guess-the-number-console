// basically importing packages. System is a fundamental pkg in .NET framework that has Random and Console
using System;
// declares a namespace, like a container
namespace GuessingGame{
    // declares a class and the main class is often named Program
    class Program{
        // static indicates Main belongs to Program class rather than an instance of Program class. We can call method directly like Program.Main()
        // console apps' starting point needs to be static
        // void -> no return
        // Main -> method name
        // string[] args -> this the cmd line argument. this declares an array of strings named args
        static void Main(string[] args)
        {
            // this is using an inbuilt instance of system pkg
            Random random =  new Random();
            // 1 is inclusive and 11 is exclusive
            int secretNumber =  random.Next(1,11);
            // Console.WriteLine($"{secretNumber}");
            Console.WriteLine("Hello, World?");

            int guess = 0;
            int attempts = 0;
            bool guessedCorrectly = false;

            Console.WriteLine("Welcome to the Guess the Number game!");
            Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess it?");

            // 2. Keep asking for guesses until the player guesses correctly
            while (!guessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                string guessInput = Console.ReadLine();

                // 3. Try to convert the input to an integer
                if (int.TryParse(guessInput, out guess))
                {
                    attempts++;

                    // 4. Check if the guess is correct, too high, or too low
                    if (guess == secretNumber)
                    {
                        guessedCorrectly = true;
                        Console.WriteLine($"Congratulations! You guessed the number {secretNumber} in {attempts} attempts!");
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(); 
        
        }

    }
}