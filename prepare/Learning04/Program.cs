using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("William Keel", "Algebra", "7.3", "8-19");
        WritingAssignment writingAssignment = new WritingAssignment("William Keel", "European History", "The Causes of WW2");
        string summary = mathAssignment.GetSummary();
        string mathHomework = mathAssignment.GetHomeworkList();
        string writingHomework = writingAssignment.GetWritingInformation();

        Console.WriteLine(summary);
        Console.WriteLine(mathHomework);
        Console.WriteLine(writingHomework);
    }
}