using System;

public class Comment{

    // member variables
    string _name, _comment;

    public Comment(string name, string text)
    {
        _name = name;
        _comment = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_name}\nComment: {_comment}");
    }
}