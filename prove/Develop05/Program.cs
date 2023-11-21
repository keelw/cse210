using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        // local variables
        int userChoice, goalType, goalPoints, checklistGoalBonus, checklistGoalCount;
        int userPoints = 0;
        string goalName, goalDescription, filename;
        int checklistGoalCurrent = 0;
        List<Goal> goals = new List<Goal>();

        // loop through the main menu to perform all user actions
        do {
            DisplayMenu(userPoints);
            userChoice = int.Parse(Console.ReadLine());

            // switch statement for the user menu
            switch(userChoice) {
                // get user input and create new goals
                case 1: 
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("\t1. Simple Goal");
                    Console.WriteLine("\t2. Eternal Goal");
                    Console.WriteLine("\t3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    goalType = int.Parse(Console.ReadLine());
                    
                    // get goal info
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    goalPoints = int.Parse(Console.ReadLine());

                    // add a simple goal
                    if (goalType == 1) 
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
                        goals.Add(simpleGoal);
                    }

                    // add an eternal goal
                    else if (goalType == 2)
                    {
                        EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                        goals.Add(eternalGoal);
                    }

                    // add a checklist goal
                    else
                    {
                        // get goal specific information for checklist goals
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        checklistGoalCount = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times?  ");
                        checklistGoalBonus = int.Parse(Console.ReadLine());

                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, checklistGoalBonus, checklistGoalCount, checklistGoalCurrent, false);
                        goals.Add(checklistGoal);
                    }
                    break;
                
                // write all the goals in the list currently
                case 2: 
                    Console.WriteLine("The goals are: ");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        goals[i].DisplayGoal(i + 1);
                    }
                    break;

                // write the goals to a file provided by the user
                case 3: 
                    Console.Write("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    
                    // write the points
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {   string goalString;
                        outputFile.WriteLine($"{userPoints}");
                        
                        // write the goal specific information
                        foreach (Goal goal in goals)
                        {
                            goalString = goal.WriteGoal();
                            outputFile.WriteLine($"{goalString}");
                        }

                    }
                    break;

                // load the goals
                case 4: 
                    // clear the existing list if any
                    goals.Clear();
                    Console.Write("What is the filename for the goal file? ");
                    filename = Console.ReadLine();

                    // read the file into an array of lines
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    // get just the points as the first line
                    userPoints = int.Parse(lines [0]);

                    // split the lines into parts and assign variables and create new objects and add them to the list
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split("|");

                        if (parts[0] == "simple")
                        {
                            SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                            goals.Add(simpleGoal);
                        }

                        else if (parts[0] == "eternal")
                        {
                            EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                            goals.Add(eternalGoal);
                        }

                        else
                        {
                            ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                            goals.Add(checklistGoal);  
                        }
                    } 
                    break;

                case 5: 
                    int goalCompleted;
                    // give the user the options
                    Console.WriteLine("The goals are: ");

                    // list out the goals
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"\t{i + 1}. {goals[i].GetName()}");
                    }

                    // get more input from the user
                    Console.Write("What goal did you accomplish? ");
                    goalCompleted = int.Parse(Console.ReadLine()) - 1; // adjusting for the 0 start of lists

                    // only give points if the goal hasn't been completed yet
                    if (!goals[goalCompleted].GetGoalCompleted())
                    {
                        // check if the goal is an object of the type ChecklistGoal and perform actions specific to that goal
                        if (goals[goalCompleted].GetType() == typeof(ChecklistGoal))
                        {
                            checklistGoalCount = goals[goalCompleted].GetChecklistGoalCount();
                            checklistGoalCurrent = goals[goalCompleted].GetChecklistGoalCurrent();
                            checklistGoalBonus = goals[goalCompleted].GetChecklistGoalBonus();
                            int pointsEarned = goals[goalCompleted].GetGoalPoints();

                            int totalPoints = checklistGoalBonus + pointsEarned;
                            goals[goalCompleted].SetChecklistGoalCurrent(checklistGoalCurrent + 1);

                            if (checklistGoalCurrent >= checklistGoalCount)
                            {
                                Console.WriteLine($"Congratulations! You have earned {totalPoints}");
                                goals[goalCompleted].SetGoalCompleted();
                            }
                        }

                        // for every other goal
                        else
                        {
                            int pointsEarned = goals[goalCompleted].GetGoalPoints();
                            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                            userPoints += pointsEarned;
                            Console.WriteLine($"You now have {userPoints} points.");
                            goals[goalCompleted].SetGoalCompleted();
                        }
                    }
                    break;

                // goodbye message and terminate the program
                case 6: 
                    Console.WriteLine("Goodbye!!");
                    break;
            }

        } while(userChoice != 6);
    }

    // this is just to display the menu over and over agian
    public static void DisplayMenu(int userPoints) {
        int _userPoints = userPoints;
        Console.WriteLine("");
        Console.WriteLine($"You have {_userPoints} points.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}