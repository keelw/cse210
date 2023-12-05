using System;

class Cycling : Activity
{
    // member variables
    private double _speed;

    // constructor
    public Cycling (double speed, DateTime date, double length) : base(date, length)
    {
        _speed = speed;
    }
    
    // getters for variables/values that aren't stored in the program
    public override double GetDistance()
    {
        return _speed * _length;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"Date: {_date} Running ({_length} min) - Distance: {Math.Round(GetDistance(), 2)} miles, Speed: {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }
}