using System;

class Running : Activity
{
    // member variables
    private double _distance;

    // constructor
    public Running (double distance, DateTime date, double length) : base(date, length)
    {
        _distance = distance;
    }

    // getters for variables/values that aren't stored in the program
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        return $"Date: {_date} Running ({_length} min) - Distance: {Math.Round(GetDistance(), 2)} miles, Speed: {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }
}