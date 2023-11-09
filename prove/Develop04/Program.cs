using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;

        do {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            switch(userInput) 
            {
                case 1: 
                    BreathingActivity breathingActivity = new BreathingActivity();
                    break;
                case 2: 
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    break;
                case 4:
                    break;
            }

        } while (userInput != 4);
    }
}