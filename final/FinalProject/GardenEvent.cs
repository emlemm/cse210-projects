using System;
using System.Collections.Generic;
using System.IO;

abstract public class GardenEvent
{
    protected string _name;
    protected Plant _plantType;
    protected string _instructions;
    protected int _howOften;

    public GardenEvent(string name, Plant plantType, int howOften)
    {
        _name = name;
        _plantType = plantType;

        _instructions = SetInstructions();
        _howOften = howOften;
    }

    public abstract string SetInstructions();

    public abstract string Serialize();

    public abstract string Method();

    public string GetDate()
    {
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        return dateText;
    }
}