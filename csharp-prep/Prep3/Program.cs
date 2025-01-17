using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, 50);
        int userGuessInt;
        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            userGuessInt = int.Parse(userGuess);

            if (randNumber < userGuessInt)
            {
                Console.WriteLine("Lower");
            }
            else if (randNumber > userGuessInt)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (userGuessInt != randNumber);
    }
}