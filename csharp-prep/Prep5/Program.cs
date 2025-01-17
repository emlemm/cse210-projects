using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string num = Console.ReadLine();
            int favNum = int.Parse(num);
            return favNum;
        }

        static int SquareNumber(int favNumber)
        {
            int sqNum = favNumber * favNumber;
            return sqNum;
        }

        static void DisplayResult(string name, int num)
        {
            Console.WriteLine($"{name}, the square of your number is {num}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int sqNum = SquareNumber(favNum);
        DisplayResult(name, sqNum);
    }
}