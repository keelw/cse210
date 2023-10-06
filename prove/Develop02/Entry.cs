using System;

class Entry 
{
    // Member variables here
    public string _date;
    public string _prompt;
    public string _response;

    // Constructor
    public Entry(){

    }

    public void CreateEntry () {
        
    }

    public void Display() {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("");
    }
}