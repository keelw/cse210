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
        string address = $"{_street}\n{_city}, {_state}, {_country}";
        return address;
    }

    public bool LivesInUSA()
    {
        if (_country == "US" || _country == "USA" || _country == "United States" || _country == "U.S.A.")
        {
            return true;
        }

        else 
        {
            return false;
        }
    }
}