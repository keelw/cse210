using System;

class Program
{
    static void Main(string[] args)
    {
        string firstname, lastname;
        Console.Write("What is your first name? ");
        firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        lastname = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}