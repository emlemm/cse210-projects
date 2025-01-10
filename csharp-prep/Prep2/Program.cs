using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int numberGrade = int.Parse(gradePercentage);

        if (numberGrade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (numberGrade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (numberGrade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (numberGrade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
    