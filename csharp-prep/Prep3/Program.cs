using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int userGuess;
        int guessCount = 0;
        bool correctGuess = false;
        
        while (correctGuess == false)
        {
            Console.Write("What is the magic number? ");
            userGuess = int.Parse(Console.ReadLine());
            guessCount ++;

            if (userGuess > number)
            {
                Console.WriteLine("Lower");
            }

            else if (userGuess < number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses.");
                correctGuess = true;
            }

            if (correctGuess == true)
            {
                break;
            }
        }
    }
}