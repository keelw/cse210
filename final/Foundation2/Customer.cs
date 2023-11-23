using System;

public class Customer
{
    // member variables
    private string _name;
    private Address _address;

    // constructor
    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA ()
    {
        return _address.LivesInUSA();
    }

    // getter for the customer name
    public string GetName ()
    {
        return _name;
    }

    // getter for the customer address
    public string GetAddress ()
    {
        return _address.GetAddress();
    }
}