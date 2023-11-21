using System;

public class ChecklistGoal : Goal{

    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, int checklistGoalBonus, int checklistGoalCount, int checklistGoalCurrent, bool checklistGoalCompleted) {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _checklistGoalBonus = checklistGoalBonus;
        _checklistGoalCount = checklistGoalCount;
        _checklistGoalCurrent = checklistGoalCurrent;
        _goalCompleted = checklistGoalCompleted;
    }

    public override void LoadGoal() {
    
    }

    public override void DisplayGoal(int goalNum) {
        if (_goalCompleted == true)
        {
            Console.WriteLine($"\t{goalNum}. [X] {_goalName} ({_goalDescription}) -- Currently completed: {_checklistGoalCurrent}/{_checklistGoalCount}");
        }

        else
        {
            Console.WriteLine($"\t{goalNum}. [ ] {_goalName} ({_goalDescription}) -- Currently completed: {_checklistGoalCurrent}/{_checklistGoalCount}");
        }
    }

    public override string WriteGoal() {
        return ($"checklist|{_goalName}|{_goalDescription}|{_goalPoints}|{_checklistGoalBonus}|{_checklistGoalCount}|{_checklistGoalCurrent}|{_goalCompleted}");
    }
}