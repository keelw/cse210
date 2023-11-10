using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square(5, "Blue");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(10, 5, "Orange");
        shapes.Add(s2);

        Circle s3 = new Circle(12, "Green");
        shapes.Add(s3);

        Rectangle s4 = new Rectangle(2, 4, "Red");
        shapes.Add(s4);

        foreach (Shape s in shapes) {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}