using System;
using System.Collections.Generic;

abstract public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _time;
    public List<string> _loadingList = new List<string>() {"|", "/", "-", "\\"};
    

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void CountdownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void LoadingAnimation(int seconds)
    {
        for (int i = seconds*2; i > 0; i--)
        {
            Console.Write(_loadingList[i%_loadingList.Count]);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}. \n\n{_description} \n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
    }

    public void EndMessage()
    {
        Console.WriteLine($"Well done!! \n\nYou have completed another {_time} seconds of the {_name}.");
        LoadingAnimation(5);
        Console.Clear();
        Program.Menu();
    }

    public virtual void LaunchActivity()
    {
        StartMessage();
        Thread.Sleep(400);
        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingAnimation(5);
    }
}