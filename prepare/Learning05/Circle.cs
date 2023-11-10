using System;
using System.Reflection.Metadata.Ecma335;

public class Circle : Shape{
    private int _radius;
    public Circle(int radius, string color) {
        _radius = radius;
        SetColor(color);
    }

    public override double GetArea() {
        return Math.PI * (_radius * _radius);
    }
}