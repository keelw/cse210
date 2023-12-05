using System;
using System.ComponentModel.Design;

class Event {
    // member variables (listed separately)
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // constructor
    public Event (string title, string description, string date, string time, Address address) 
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // message generators

    public string GetStandardDetails ()
    {
        string standardDetails = $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
        return standardDetails;
    }

    public string GetShortDescription ()
    {
        string shortDescription;
        
        if (this.GetType() == typeof(Lecture))
        {
            shortDescription = $"Lecture:\nTitle: {_title}\nDate: {_date}";
        }

        else if (this.GetType() == typeof(Reception))
        {
            shortDescription = $"Reception:\nTitle: {_title}\nDate: {_date}";
        }

        else 
        {
            shortDescription = $"Outdoor Gathering:\nTitle: {_title}\nDate: {_date}";
        }

        return shortDescription;
    }

}