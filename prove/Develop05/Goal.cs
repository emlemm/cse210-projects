using System;
using System.Collections.Generic;
using System.IO;

abstract public class Goal
{
    protected string _typeOfGoal = "0";
    protected string _name = "";
    protected string _description = "";
    protected int _points = 0;

    public Goal(string typeOfGoal, string name, string description, int points)
    {
        _typeOfGoal = typeOfGoal;
        _name = name;
        _description = description;
        _points = points;
    }

    public static Goal CreateGoal()
    {
        Console.WriteLine(@"The types of goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal");
        
        Console.Write("Which type of goal would you like to create? ");
        string typeOfGoal = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with the goal? ");
        int points = int.Parse(Console.ReadLine());

        if (typeOfGoal == "1")
        {
            SimpleGoal sGoal = new SimpleGoal(name, description, points, false); 
            Console.WriteLine("You have made a new Simple Goal. Great job!");
            return sGoal;
        }
        else if (typeOfGoal == "2")
        {
            EternalGoal eGoal = new EternalGoal(name, description, points);
            Console.WriteLine("You have made a new Eternal Goal. Great job!");
            return eGoal;
        }
        else if (typeOfGoal == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int totalTimesNeeded = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal cGoal = new ChecklistGoal(name, description, points, bonusPoints, totalTimesNeeded);
            Console.WriteLine("You have made a new Checklist Goal. Great job!");
            return cGoal;
        } 
        else 
        {
            Console.WriteLine("Invalid input.");
            return CreateGoal();
        }
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public abstract bool CheckCompletion();

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[{(CheckCompletion()?'X':' ')}] {_name} ({_description})");
    }

    public static Goal Deserialize(string line)
    {
        string[] parts = line.Split("|");

        Goal goal;
        if (parts[0] == "1")
        { 
            goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
        }
        else if (parts[0] == "2")
        {
            goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
        }
        else if (parts[0] == "3")
        {
            if (parts.Length == 6)
            {
                goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
            }
            else
            {
                goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
            }    
        }
        else 
        {
            throw new Exception();
        }
        return goal;
    }

    public virtual string Serialize()
    {
        return $"{_typeOfGoal}|{_name}|{_description}|{_points}";
    }

    public string GetName()
    {
        return _name;
    }
}