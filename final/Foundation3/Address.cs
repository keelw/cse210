using System;

public class Address
{
    // member variables
    private string _street, _city, _state, _country;
    
    // constructor
    public Address (string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        string address = $"\n\t{_street}\n\t{_city}, {_state}, {_country}";
        return address;
    }
}