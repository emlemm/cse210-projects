using System;
using System.ComponentModel;

public class PlantingEvent : GardenEvent
{
    private int _sqFeet;

    public PlantingEvent(Plant plantType, string eventDate, int sqFeet) 
    : base("Planted", plantType, eventDate)
    {
        _eventDate = eventDate;
        _sqFeet = sqFeet;
    }
    
    public static PlantingEvent CreateEvent()
    {
        Console.Write("What plant did you plant in your garden? ");
        string plant = Console.ReadLine();
        string eventDate = GetDate();
        Console.Write($"How many square feet of {plant}s did you plant? ");
        int sqFeet = int.Parse(Console.ReadLine());

        PlantingEvent p = new PlantingEvent(plant, eventDate, sqFeet);
        return p;
    }


    public override string ToString()
    {
        string displayEvent = $@"
Date: {_eventDate} -
    {_name}: {_plantType.GetName}
    Sq. Feet: {_sqFeet}
";
        return displayEvent;
    }

    public override string Serialize()
    {
      return base.Serialize() + $"|{_sqFeet}";
    }

    // Then Deserialize should return an fully fledged event by reading that simple string with the "|" as a separator
    public static GardenEvent Deserialize(string line)
    {
        string[] parts = line.Split("|");
    }
}