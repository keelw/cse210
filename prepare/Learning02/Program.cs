using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a job
        Job job1 = new Job();
        job1._company = "Digicert";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
        job1._endYear = 2023;

        // Create a job
        Job job2 = new Job();
        job2._company = "Weave";
        job2._jobTitle = "Tester";
        job2._startYear = 2017;
        job2._endYear = 2021;

        // Create an instance of resume for myself
        Resume resume = new Resume();
        resume._name = "William Keel";

        // Add the jobs to the resume
        resume._jobsList.Add(job1);
        resume._jobsList.Add(job2);

        // Display the resume
        resume.Display();
    }
}