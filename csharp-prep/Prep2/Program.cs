using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int numberGrade = int.Parse(gradePercentage);
        string letterGrade = "";

        if (numberGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (numberGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (numberGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (numberGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        Console.WriteLine("");
        Console.WriteLine($"Your grade is a(n) {letterGrade}.");

        if (numberGrade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
        else 
        {
            Console.WriteLine("Keep working hard, you'll get it next time.");
        }
    }
}
    