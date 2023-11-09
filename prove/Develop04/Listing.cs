using System;

class ListingActivity : Activity {
    
    public ListingActivity() : base() {
        DisplayWelcome(3);
        Console.WriteLine("");

        // Listing activity specific code
        // get start and end times
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        // get the current time
        DateTime currentTime = startTime;

        // list of prompts
        List<string> prompts = new List<string>{"Who are people that you appreciate?",
                                                "What are personal strengths of yours?",
                                                "Who are people that you have helped this week?",
                                                "When have you felt the Holy Ghost this month?",
                                                "Who are some of your personal heros?"
        };

        // Declare and initialize the counter
        int entryCount = 0;

        // Get a random number for the prompt
        Random rnd = new Random();
        int random = rnd.Next(0, 4);

        string prompt = prompts[random];

        // Display the prompts
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---{prompt}---");

        // Prepare the user
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine("");

        while (currentTime <= endTime) {
            Console.Write("> ");
            
            // Quit if the user is taking forever to answer the prompt...
            if (currentTime >= endTime) {
                break;
            }
            
            Console.ReadLine();

            entryCount++;
            currentTime = DateTime.Now;
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed {entryCount} items!");

        DisplayExit();
    }
}