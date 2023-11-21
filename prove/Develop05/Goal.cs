using System;

public abstract class Goal
{
    // member variables
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints, _checklistGoalBonus, _checklistGoalCount, _checklistGoalCurrent;
    protected bool _goalCompleted;
    
    public Goal() {

    }

    // getter for the name
    public string GetName()
    {
        return _goalName;
    }

    // getter for the point value
    public int GetGoalPoints() 
    {
        return _goalPoints;
    }

    // getter for the goalCompleted status
    public bool GetGoalCompleted()
    {
        return _goalCompleted;
    }

    // setter for the goalCompleted status
    public void SetGoalCompleted()
    {
        _goalCompleted = true;
    }

    public abstract void DisplayGoal(int integer);

    public abstract string WriteGoal();

    public abstract void LoadGoal();


    public int GetChecklistGoalCurrent()
    {
        return _checklistGoalCurrent;
    }

    public int GetChecklistGoalCount()
    {
        return _checklistGoalCount;
    }

    public void SetChecklistGoalCurrent(int checklistGoalCurrent)
    {
        _checklistGoalCurrent = checklistGoalCurrent;
    }

    public int GetChecklistGoalBonus()
    {
        return _checklistGoalBonus;
    }


}