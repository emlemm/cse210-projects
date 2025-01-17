using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, 50);
        int userGuessInt;
        int numberOfGuesses = 0;
        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            userGuessInt = int.Parse(userGuess);

            if (randNumber < userGuessInt)
            {
                numberOfGuesses += 1;
                Console.WriteLine("Lower");
            }
            else if (randNumber > userGuessInt)
            {
                numberOfGuesses += 1;
                Console.WriteLine("Higher");
            }
            else
            {
                numberOfGuesses += 1;
                Console.WriteLine("You guessed it!");
            }
        } while (userGuessInt != randNumber);

        Console.WriteLine($"You took {numberOfGuesses} guess(es) to get it right.");
    }
}