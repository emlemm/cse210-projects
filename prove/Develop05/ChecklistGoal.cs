using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints = 0;
    private int _timesAccomplished = 0;
    private int _totalTimesNeeded;
    
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int totalTimesNeeded) 
    : base("3", name, description, points)
    {
        _bonusPoints = bonusPoints;
        _totalTimesNeeded = totalTimesNeeded;
    }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int totalTimesNeeded, int timesAccomplished) 
    : this(name, description, points, bonusPoints, totalTimesNeeded)
    {
        _timesAccomplished = timesAccomplished;
    }

    public override bool CheckCompletion()
    {
        return _timesAccomplished >= _totalTimesNeeded;
    }

    public override int RecordEvent()
    {
        _timesAccomplished += 1;
        if (CheckCompletion())
        {
            return _points + _bonusPoints;
        }
        else 
        {
            return base.RecordEvent();
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(CheckCompletion()?'X':' ')}] {_name} ({_description}) -- Currently Completed: {_timesAccomplished}/{_totalTimesNeeded}");
    }

    public override string Serialize()
    {
        return base.Serialize()+$"|{_bonusPoints}|{_totalTimesNeeded}|{_timesAccomplished}";
    }
}