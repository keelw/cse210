using System;

class Activity {
    // member variables
    protected int _activityDuration;
    private int _activityNumber;
    private string _activityName;
    private string _activityDescription;

    public Activity () {

    }

    // Intro message 
    public void DisplayWelcome(int activityNumber) {
        _activityNumber = activityNumber;
        
        switch(_activityNumber) 
        {
            case 1: 
                _activityName = "Breathing";
                _activityDescription = ("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                break;
            case 2: 
                _activityName = "Reflecting";
                _activityDescription = ("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                break;
            case 3:
                _activityName = "Listing";
                _activityDescription = ("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                break;
        }

        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        
        // Description
        Console.WriteLine(_activityDescription);
        Console.WriteLine();

        // Activity length
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());

        // Get ready...
        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowAnimation(4);
    }

    // Animate a "loading" symbol for a given number of seconds
    public void ShowAnimation(int pauseLength) {
        string _animation;
        int _animationDuration = pauseLength;
        
        // get start and end times
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_animationDuration);

        // get the current time
        DateTime currentTime = DateTime.Now;

        // loop while the current time is less than the end time
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;

            Console.Write("");
            // 0 dots
            _animation = "";
            Console.Write(_animation);
            Thread.Sleep(500);

            // 1 dot
            _animation += ".";
            Console.Write(_animation);
            Thread.Sleep(500);
            Console.Write("\b \b\b");

            // 2 dots
            _animation += ".";
            Console.Write(_animation);
            Thread.Sleep(500);
            Console.Write("\b\b  \b\b");
            
            // 3 dots
            _animation += ".";
            Console.Write(_animation);
            Thread.Sleep(500);
            Console.Write("\b\b\b   \b\b\b");
        }
    }

    // Animate a countdown that can be used by activities
    public void ShowCountdown(int pauseLength) {
        int _pauseLength = pauseLength;
        
        for (int i = _pauseLength; i > 0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Display the well done, exit message, and animations at the end of each activity
    public void DisplayExit() {
        Console.WriteLine("Well done!!");
        ShowAnimation(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        ShowAnimation(3);
    }
}