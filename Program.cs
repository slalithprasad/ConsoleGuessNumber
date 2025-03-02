Random random = new Random();

int nearDifference = 10;

Console.WriteLine("🎯 Welcome to Guess the Number!");

while (true)
{
    int secretNumber = random.Next(1, 101);
    int attempts = 0;
    bool guessedTheNumber = false;

    Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!");

    while (!guessedTheNumber)
    {
        Console.Write("Enter your guess: ");
        if (int.TryParse(Console.ReadLine(), out int userGuess))
        {
            attempts++;
            int difference = Math.Abs(secretNumber - userGuess);

            if (userGuess == secretNumber)
            {
                Console.WriteLine($"🎉 Congratulations! You guessed it in {attempts} attempts.");
                guessedTheNumber = true;
            }
            else if (userGuess > secretNumber)
            {
                Console.WriteLine(difference <= nearDifference ? "High! You're very close!" : "Too High!");
            }
            else
            {
                Console.WriteLine(difference <= nearDifference ? "Low! You're very close!" : "Too Low!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    Console.Write("Do you want to play again? (y/n): ");
    if (Console.ReadLine()?.ToLower() != "y")
        break;
}

Console.WriteLine("Thanks for playing! Goodbye.");
Console.ReadLine();
