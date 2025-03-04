using System;

public class Rectangle : Shape
{
    private double _width;
    private double _length;

    public Rectangle(string color, double width, double length) : base(color)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        double area = _width * _length;
        return Math.Round(area, 1);
    }
}