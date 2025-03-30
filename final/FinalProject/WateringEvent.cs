using System;
using System.ComponentModel;

public class WateringEvent : GardenEvent
{
    private TimeSpan _frequency;

    public WateringEvent(string name, Plant plantType, int howOften, TimeSpan frequency) : base(name, plantType, howOften)
    {
        _frequency = frequency;
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