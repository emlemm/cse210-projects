using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numberAdded;
        do
        {
            Console.Write("Enter Number: ");
            string userNumber = Console.ReadLine();
            numberAdded = int.Parse(userNumber);
            if (numberAdded != 0)
            {
                numbers.Add(numberAdded);
            }
        } while (numberAdded != 0);
        
        int sum = 0;
        float average;
        int largest;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

    }
}