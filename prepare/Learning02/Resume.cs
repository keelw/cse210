using System;

public class Resume 
{
    // Member variables
    public string _name;
    public List<Job> _jobsList = new List<Job>();

    // Constructor
    public Resume() {

    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobsList)
        {
            job.Display();
        }
    }
}