using System;
using System.Runtime.CompilerServices;

class Outdoor : Event{
    // unique member variables
    private string _weather;
    public Outdoor (string title, string description, string date, string time, Address address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetFullDetails ()
    {
        string fullDetails;

        fullDetails = GetStandardDetails()+ $"\nWeather: {_weather}";

        return fullDetails;
    }

}