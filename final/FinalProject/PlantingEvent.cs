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
        Plant plantObject = DeterminePlantType("plant");
        string eventDate = GetDate();
        Console.Write($"How many square feet did you plant? ");
        int sqFeet = int.Parse(Console.ReadLine());

        PlantingEvent p = new PlantingEvent(plantObject, eventDate, sqFeet);
        return p;
    }

    public override string ToString()
    {
        string displayEvent = $@"
Date: {_eventDate} -
    {_name}: {_plantType.GetName()}
    Sq. Feet: {_sqFeet}
";
        return displayEvent;
    }

    public override string Serialize()
    {
      return base.Serialize() + $"|{_sqFeet}";
    }

    public static PlantingEvent Deserialize(string line)
    {
        string[] parts = line.Split("|");

        PlantingEvent p;
        if (parts[0] == "Planted")
        {
            Plant plantName = Lookup(parts[1]);
            p = new PlantingEvent(plantName, parts[2], int.Parse(parts[3]));
        }
        else 
        {
            throw new Exception();
        }
        return p;
    }
}