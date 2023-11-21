using System;

public class EternalGoal : Goal{

    public EternalGoal(string goalName, string goalDescription, int goalPoints) {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _goalCompleted = false;
    }

    public override void LoadGoal() {
    
    }

    public override void DisplayGoal(int goalNum) {
        Console.WriteLine($"\t{goalNum}. [ ] {_goalName} ({_goalDescription})");
    }

    public override string WriteGoal() {
        return ($"eternal|{_goalName}|{_goalDescription}|{_goalPoints}|{_goalCompleted}");
    }
}