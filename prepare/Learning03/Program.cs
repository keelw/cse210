using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(6);
        Fraction test3 = new Fraction(3,8);

        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine("");

        Console.WriteLine(test1.GetDecimalValue());
        Console.WriteLine(test2.GetDecimalValue());
        Console.WriteLine(test3.GetDecimalValue());
        Console.WriteLine("");

        test1.SetNumerator(5);
        test1.SetDenominator(12);
        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());
    }
}