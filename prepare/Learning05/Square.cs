using System;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape{
    private int _side;
    public Square(int side, string color) {
        _side = side;
        SetColor(color);
    }

    public override double GetArea() {
        return _side * _side;
    }
}