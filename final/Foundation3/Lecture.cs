using System;
using System.Runtime.CompilerServices;

class Lecture : Event{
    // unique member variables
    private string _speakerName;
    private int _capacity;
    // constructor
    public Lecture (string title, string description, string date, string time, Address address, string speakerName, int capacity) : base (title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetFullDetails ()
    {
        string fullDetails;

        fullDetails = GetStandardDetails()+ $"\nSpeaker: {_speakerName}\nCapacity: {_capacity}";

        return fullDetails;
    }
}