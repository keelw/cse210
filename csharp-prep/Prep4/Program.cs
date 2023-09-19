using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Declare/initialize variables
        List<int> numbers = new List<int>();
        int userNumber = 1;
        int sum = 0;
        int count = 0;
        int maxNumber = 0;
        float average;

        // Introductory message
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        // Use this while loop to get information from the user
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            
            if (userNumber == 0)
            {
                break;
            }

            count++;
            sum += userNumber;

            if (userNumber > maxNumber)
            {
                maxNumber = userNumber;
            }

            // Add the number to the list
            numbers.Add(userNumber);
        }

        Console.WriteLine($"The count is: {count}");
        // Perform the required calculations
        average = (float)sum / count;

        // Print out the information to the user. 
        Console.WriteLine($"The sum it: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}