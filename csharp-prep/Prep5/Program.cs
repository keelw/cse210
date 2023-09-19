using System;
using System.Net;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName()
    {
        String name;
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        int favNumber;
        Console.Write("Please enter your favorie number: ");
        favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int favNumber)
    {
        int squareNumber = favNumber * favNumber;
        return squareNumber;
    }

    static void DisplayResult(String name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}