using System;

class BreathingActivity : Activity {
    
    public BreathingActivity() : base() {
        DisplayWelcome(1);
        Console.WriteLine("");

        // Breathing activity specific code
        // get start and end times
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        // get the current time
        DateTime currentTime = startTime;

        while (currentTime <= endTime) {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine("");
            Console.Write("Now breathe out... ");
            ShowCountdown(6);
            Console.WriteLine("");
            Console.WriteLine("");

            currentTime = DateTime.Now;
        }

        DisplayExit();
    }
}