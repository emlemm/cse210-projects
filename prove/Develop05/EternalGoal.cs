using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
    : base("2", name, description, points)
    {}
    public override bool CheckCompletion()
    {
        return false;
    }
}