using System;
using System.ComponentModel;

public class PlantingEvent : GardenEvent
{
    private int _sqFeet;

    public PlantingEvent(string name, Plant plantType, int howOften, int sqFeet) : base(name, plantType, howOften)
    {
        _sqFeet = sqFeet;
    }

    // Will fill this in later-
    public override string SetInstructions()
    {
        string instructions = "";
        return instructions;
    }

    // Will fill this in later-
    public override string Serialize()
    {
        string serialize = "Fix this";
        return serialize;
    }

    // Will fill this in later-
    public override string Method()
    {
        string method = "Fix this later";
        return method;
    }
}