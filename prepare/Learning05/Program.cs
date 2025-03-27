using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("blue", 4.5);
        Rectangle rec = new Rectangle("pink", 3, 7.1);
        Circle cir = new Circle("green", 2.4);
       
        List<Shape> shapes = new List<Shape>() {sq, rec, cir};
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"This is a {color} {shape.GetType().Name.ToLower()}, with an area of {area} feet squared.");
        }
    }
}