using System;

class Activity 
{
    // member variables
    protected DateTime _date;
    protected double _length;

    // constructor(s)
    public Activity (DateTime date, double length)
    {
        _date = date;
        _length = length;
    }

    // getters for variables/values that aren't stored in the program
    public virtual double GetDistance()
    {
        // stub value
        return 0;
    }

    public virtual double GetSpeed()
    {
        // stub value
        return 0;
    }

    public virtual double GetPace()
    {
        // stub value
        return 0;
    }

    public virtual string GetSummary()
    {
        // stub value
        return "";
    }
}