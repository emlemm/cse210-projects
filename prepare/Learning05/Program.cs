using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("blue", 4.5);
        string sqColor = sq.GetColor();
        double sqArea = sq.GetArea();
        Console.WriteLine($"This is a {sqColor} square, with an area of {sqArea} feet squared.");

        Rectangle rec = new Rectangle("pink", 3, 7.1);
        string recColor = rec.GetColor();
        double recArea = rec.GetArea();
        Console.WriteLine($"This is a {recColor} rectangle, with an area of {recArea} feet squared.");

        Circle cir = new Circle("green", 2.4);
        string cirColor = cir.GetColor();
        double cirArea = cir.GetArea();
        Console.WriteLine($"This is a {cirColor} circle, with an area of {cirArea} feet squared.");

        List<Shape> shapes = new List<Shape>() {sq, rec, cir};
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"This is a {color} {shape.GetType().Name.ToLower()}, with an area of {area} feet squared.");
        }
    }
}