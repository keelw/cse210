using System;

public class SimpleGoal : Goal{

    public SimpleGoal(string goalName, string goalDescription, int goalPoints, bool goalCompleted) {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _goalCompleted = goalCompleted;
    }

    public override void LoadGoal() {
    
    }

    public override void DisplayGoal(int goalNum) {
        if (_goalCompleted == true)
        {
            Console.WriteLine($"\t{goalNum}. [X] {_goalName} ({_goalDescription})");
        }

        else
        {
            Console.WriteLine($"\t{goalNum}. [ ] {_goalName} ({_goalDescription})");
        }
    }

    public override string WriteGoal() {
        return ($"simple|{_goalName}|{_goalDescription}|{_goalPoints}|{_goalCompleted}");
    }
}