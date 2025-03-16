using System;

public class SimpleGoal : Goal
{
    private bool _ifComplete = false;

    public SimpleGoal(string name, string description, int points, bool ifComplete) 
    : base("1", name, description, points)
    {
        _ifComplete = ifComplete;
    }

    public override bool CheckCompletion()
    {
        return _ifComplete;
    }

    public override string Serialize()
    {
        return base.Serialize() + $"|{_ifComplete}";
    }
    
    public override int RecordEvent()
    {
        _ifComplete = true;
        return base.RecordEvent();
    }
}