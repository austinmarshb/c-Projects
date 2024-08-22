int userGuess = 0;
int secretNumber;
int counter = 0;
int amountOfGuesses = 0;

Random r = new Random();
secretNumber = r.Next(0, 100);

Console.WriteLine("I'm thinking of a secret number between 1-100.\n" +
                  "Would you like 'easy' mode (10 guesses) or 'hard' mode (5 guesses)?");

string difficulty = Console.ReadLine().ToLower();

if (difficulty == "easy")
{
    amountOfGuesses = 10;
}
else if (difficulty == "hard")
{
    amountOfGuesses = 5;
}

while (userGuess != secretNumber)
{
    Console.WriteLine("Take a guess!");
    userGuess = int.Parse(Console.ReadLine());
        if (userGuess < secretNumber)
    {
        counter++;
        amountOfGuesses--;
        Console.WriteLine($"Sorry, too low! You have {amountOfGuesses} guesses left.");
    }
        else if (userGuess > secretNumber)
    {
        counter++;
        amountOfGuesses--;
        Console.WriteLine($"Sorry, too high! You have {amountOfGuesses} guesses left.");
    }
        else if (userGuess == secretNumber)
    {
        counter++;
        Console.WriteLine($"You got it! I was thinking of {secretNumber}! It took you {counter} tries.");
    }
}

Console.ReadKey();
