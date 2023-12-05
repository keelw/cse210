using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // create the activities
        Running running = new Running(5.4, DateTime.Now, 48.0);
        Cycling cycling = new Cycling(18.6, DateTime.Now, 146.9);
        Swimming swimming = new Swimming(10, DateTime.Now, 99.8);

        // create a list and add activities to it
        List<Activity> activities = new List<Activity> 
        {
            running,
            cycling,
            swimming
        };

        // Get a summary for each item in the list
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("");
        }
    }
}