using System;

class Swimming : Activity
{
    // member variables
    private double _laps;

    // constructor
    public Swimming (double laps, DateTime date, double length) : base(date, length)
    {
        _laps = laps;
    }

    // getters for variables/values that aren't stored in the program
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * .62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"Date: {_date} Running ({_length} min) - Distance: {Math.Round(GetDistance(), 2)} miles, Speed: {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }
}