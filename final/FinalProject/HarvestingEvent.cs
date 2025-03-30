using System;
using System.ComponentModel;

public class HarvestingEvent : GardenEvent
{
    private int _yield;

    public HarvestingEvent(string name, Plant plantType, int howOften, int yield) : base(name, plantType, howOften)
    {
        _yield = yield;
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
        string serialize = "Fix this later";
        return serialize;
    }

    // Will fill this in later-
    public override string Method()
    {
        string method = "Fix this later";
        return method;
    }
}