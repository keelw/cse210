using System;
using System.Reflection.Metadata.Ecma335;

public class Rectangle : Shape{
    private int _side1;
    private int _side2;

    public Rectangle(int side1, int side2, string color) {
        _side1 = side1;
        _side2 = side2;
        SetColor(color);
    }

    public override double GetArea() {
        return _side1 * _side2;
    }
}