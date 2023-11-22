using System;
using System.Runtime.CompilerServices;

public class Video
{
    // member variables
    private List<Comment> _comments = new List<Comment>();
    private string _title, _author;
    private double _length;

    public Video (string title, string author, double length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    // getter for the title
    public string GetTitle()
    {
        return _title;
    }

    // getter for the author
    public string GetAuthor()
    {
        return _author;
    }

    // getter for the length
    public double GetLength()
    {
        return _length;
    }

    // getter for the comments
    public List<Comment> GetComments()
    {
        return _comments;
    }

    // getter for the comment count
    public int CommentCount()
    {
        return _comments.Count();
    }


}