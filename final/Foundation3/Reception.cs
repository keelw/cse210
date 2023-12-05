using System;
using System.Runtime.CompilerServices;

class Reception : Event{
    // unique member variables
    private string _email;
    public Reception (string title, string description, string date, string time, Address address, string email) : base (title, description, date, time, address)
    {
        _email = email;
    }

    public string GetFullDetails ()
    {
        string fullDetails;

        fullDetails = GetStandardDetails()+ $"\nRSVP to: {_email}";

        return fullDetails;
    }

}