using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstFraction = new Fraction();
        firstFraction.Display();
        int top = firstFraction.GetTop();
        Console.WriteLine(top);
        firstFraction.SetTop(3);
        int newTop = firstFraction.GetTop();
        firstFraction.Display();

        Fraction secondFraction = new Fraction(6);
        secondFraction.Display();
        secondFraction.SetBottom(4);
        secondFraction.Display();

        Fraction thirdFraction = new Fraction(6, 7);
        thirdFraction.Display();
        thirdFraction.SetTop(3);
        thirdFraction.SetBottom(4);
        Console.WriteLine(thirdFraction.GetFractionString());
        Console.WriteLine(thirdFraction.GetDecimalValue());

        Fraction fourthFraction = new Fraction(5);
        Console.WriteLine(fourthFraction.GetFractionString());
        Console.WriteLine(fourthFraction.GetDecimalValue());

    }
}