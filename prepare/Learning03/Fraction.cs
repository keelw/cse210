using System;

public class Fraction {

    // Member variables
    private int numerator;
    private int denominator;

    // Constructors
    public Fraction() {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int num) {
        numerator = num;
        denominator = 1;
    }

    public Fraction(int num, int den) {
        numerator = num;
        denominator = den;
    }

    // Getters and Setters
    public int GetNumerator() {
        return numerator;
    }

    public int GetDenominator() {
        return denominator;
    }

    public void SetNumerator(int num) {
        numerator = num;
    }

    public void SetDenominator(int num) {
        denominator = num;
    }

    // Methods
    public String GetFractionString() {
        string fractionString = $"{numerator}/{denominator}";
        return fractionString;
    }

    public double GetDecimalValue() {
        double decimalValue = ((double)numerator / denominator );
        return decimalValue;
    }
}