using System;

class ReflectingActivity : Activity {
    
    public ReflectingActivity() : base() {
        DisplayWelcome(1);
        Console.WriteLine("");

        // Reflecting activity specific code
        // get start and end times
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        // get the current time
        DateTime currentTime = startTime;

        // list of prompts
        List<string> prompts = new List<string>{"Think of a time when you stood up for someone else.",
                                                "Think of a time when you did something really difficult.",
                                                "Think of a time when you helped someone in need.",
                                                "Think of a time when you did something truly selfless.",
                                                "Think of the hardest thing you have ever done."
        };

        // list of questions
        List<string> questions = new List<string>{"Why was this experience meaningful to you?",
                                                "Have you ever done anything like this before?",
                                                "How did you get started?",
                                                "How did you feel when it was complete?",
                                                "What made this time different than other times when you were not as successful?",
                                                "What is your favorite thing about this experience?",
                                                "What could you learn from this experience that applies to other situations?",
                                                "What did you learn about yourself through this experience?",
                                                "How can you keep this experience in mind in the future?"
        };


        // Get a random number for the prompt
        Random rndPrompt = new Random();
        int random = rndPrompt.Next(0, 4);

        string prompt = prompts[random];

        // Display the prompt to the user
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        while (currentTime <= endTime) {
            Random rndQuestion = new Random();
            int rnd = rndQuestion.Next(0, 8);

            string question = questions[rnd];

            Console.WriteLine($"{question} ");
            ShowAnimation(7);
            Console.WriteLine("");

            currentTime = DateTime.Now;
        }

        DisplayExit();
    }
}