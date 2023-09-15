using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        float percentage;
        char letter;

        Console.Write("Enter your grade percentage: ");
        percentage = float.Parse(Console.ReadLine());

        if (percentage >= 90)
        {
            letter = 'A';
        }

        else if (percentage < 90 && percentage >= 80)
        {
            letter = 'B';
        }

        else if (percentage < 80 && percentage >= 70)
        {
            letter = 'C';
        }

        else if (percentage < 70 && percentage >= 60)
        {
            letter = 'D';
        }

        else
        {
            letter = 'F';
        }

        Console.WriteLine("");
        Console.WriteLine($"Your letter grade is: {letter}.");

        if (percentage < 70)
        {
            Console.WriteLine("You failed. Better luck next time!");
        }

        else
        {
            Console.WriteLine("You passed. Congratulations!");
        }
    }
}