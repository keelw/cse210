using System;
using System.IO.Enumeration;

class Program
{
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        bool continueRunning = true;
        while (continueRunning == true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.Write("Enter your selection: ");

            int userChoice = int.Parse(Console.ReadLine());

            // To decide what happens based on int userChoice
            switch (userChoice)
            {
                case 1:
                WriteEntry();
                break;

                case 2:
                DisplayJournal();
                break;

                case 3:
                LoadJournal();
                break;

                case 4:
                SaveJournal();
                break;

                case 5:
                Console.WriteLine("See you next time!");
                continueRunning = false;
                break;
            }
        }
    }

    // This function will provide the user a random prompt, save their response 
    // to a entry object, get a date and save it to the entry object, as well as the prompt
    static void WriteEntry() {
        // get the prompt
        string prompt = GetPrompt();

        // provide it to the user
        Console.WriteLine(prompt);

        // get their response
        string response = Console.ReadLine();

        // get the current date and time
        DateTime currentDateTime = DateTime.Now;

        // make it a string
        string dateString = currentDateTime.ToString("yyyy MMMM dd HH:mm:ss");

        // create the entry object and assign it's variables
        Entry entry = new Entry();
        entry._date = dateString;
        entry._prompt = prompt;
        entry._response = response;

        // add the entry to the session journal object
        journal.AddEntry(entry);
    }

    // This function will iterate through all the entries in the journal object and display
    // them to the screen
    static void DisplayJournal() {
        journal.DisplayJournal();
    }

    // This function will prompt the user for a filename and then load a journal from the file
    // this should replace any entries currently stored in the journal
    static void LoadJournal() {
        // Get the file from the user
        Console.WriteLine("Enter the file you want to load: ");
        string fileName = Console.ReadLine();

        // reset the journal file
        journal = new Journal();

        // read the file
        string[] lines = System.IO.File.ReadAllLines(fileName);

        // store the file into a new journal object
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            journal.AddEntry(entry);
        }
    }


    // This function will prompt the user for a filename and then save the current journal 
    // object to the file
    static void SaveJournal() 
    {
        // Get the file from the user
        Console.Write("Enter the name and path of the file where you want to save this journal: ");
        string fileName = Console.ReadLine();

        // Call the save function from the journal class
        journal.SaveJournal(fileName);
    }

    // This helper function will simply generate a random prompt from a list and return it
    static string GetPrompt() {
        List<string> promptList = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is the most impactful thing I did today?",
            "How did you further the Lord's work today?",
            "What were you most frustrated about today?"
        };

        Random rd = new Random();
        int rand_num = rd.Next(1,8);

        return promptList[rand_num];
    }
}