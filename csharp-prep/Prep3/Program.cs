using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int userNumber = int.Parse(magicNumber);

        int userGuessInt;
        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            userGuessInt = int.Parse(userGuess);

            if (userNumber < userGuessInt)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber > userGuessInt)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (userGuessInt != userNumber);
    }
}