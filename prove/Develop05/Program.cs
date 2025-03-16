// For exceeding the requirements, I used the loading animation from the scripture memorization program 
// to help ease transitions between steps. I also created an extra step before the user can quit 
// to ask them if they need to save before quitting.

using System;

class Program
{
    private static int _score = 0;
    private static List<Goal> _currentGoals = new List<Goal>();
    static void Main(string[] args)
    {
        Console.Clear();
        Menu();
    }

    static void Menu()
    {
        DisplayScore();
        Console.Write($@"
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. QUIT
Select a choice from the menu: ");

        string response = Console.ReadLine();
        switch (response)
        {
            case "1":
                Console.Clear();
                Goal newGoal = Goal.CreateGoal();
                _currentGoals.Add(newGoal);
                LoadingAnimation(3);
                Console.Clear();
                Menu();
                break;
            case "2":
                Console.Clear();
                DisplayGoalsList(_currentGoals);
                Console.Write("\nPress enter to return to the menu: ");
                Console.ReadLine();
                LoadingAnimation(2);
                Console.Clear();
                Menu();
                break;
            case "3":
                Console.Clear();
                SaveGoals(_currentGoals);
                Console.WriteLine("File has been saved.");
                LoadingAnimation(2);
                Console.Clear();
                Menu();
                break;
            case "4":
                Console.Clear();
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                _currentGoals.AddRange(Load(fileName));
                Console.WriteLine("File loaded. Goals ready to be viewed.");
                LoadingAnimation(2);
                Console.Clear();
                Menu();
                break;
            case "5":
                Console.Clear();
                StartRecordEvent();
                LoadingAnimation(3);
                Console.Clear();
                Menu();
                break;
            case "6":
                Console.Clear();
                ConfirmQuit();
                break;
        }
    }

    private static void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    private static void DisplayGoalsList(List<Goal> goalsList) 
    {
        for (int i = 0; i < goalsList.Count; i++)
        {
            Console.Write($"{i+1}. ");
            goalsList[i].DisplayGoal();
        }
}

    private static List<Goal> Load(string fileName)
    {
        List<Goal> goalsList = new List<Goal>();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            Goal goal = Goal.Deserialize(line);
            goalsList.Add(goal);
        }
        return goalsList;
    }

    private static void SaveGoals(List<Goal> currentGoals)
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName)) 
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in currentGoals)
                {
                    outputFile.WriteLine(goal.Serialize());
                }   
        }
    }

    private static void StartRecordEvent()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _currentGoals.Count; i++ )
        {
            Console.WriteLine($"{i+1}. {_currentGoals[i].GetName()}");
        }
        
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine())-1;
        int addedPoints = _currentGoals[goalIndex].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {addedPoints} points!");
        
        _score += addedPoints;
        Console.WriteLine($"\nYou now have {_score} points.");
    }

    private static void LoadingAnimation(int seconds)
    {
        List<string> _loadingList = new List<string>() {"|", "/", "-", "\\"};
        for (int i = seconds*2; i > 0; i--)
        {
            Console.Write(_loadingList[i%_loadingList.Count]);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    private static void ConfirmQuit()
    {
        Console.Write(@"Do you need to save before you quit?
    1. Save and then quit
    2. Cancel - return to menu
    3. QUIT        
Select a choice from the menu: ");

        string response = Console.ReadLine();
        switch (response)
        {
            case "1":
                Console.Clear();
                SaveGoals(_currentGoals);
                Console.WriteLine("File has been saved.");
                Thread.Sleep(800);
                Console.Write("\nThanks for using The Eternal Quest Program! Goodbye.");
                return;
            case "2":
                LoadingAnimation(2);
                Console.Clear();
                Menu();
                break;
            case "3":
                Console.Write("\nThanks for using The Eternal Quest Program! Goodbye.");
                return;
        }
    }
}