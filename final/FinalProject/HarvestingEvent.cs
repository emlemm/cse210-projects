using System;
using System.ComponentModel;
using System.Net;

public class HarvestingEvent : GardenEvent
{
    private int _yield;
    private bool? _harvestAgain = null;

    public HarvestingEvent(Plant plantType, string eventDate, int yield, bool? harvestAgain) 
    : base("Harvested", plantType, eventDate)
    {
        _eventDate = eventDate;
        _yield = yield;
        _harvestAgain = harvestAgain;
    }
    
    public static HarvestingEvent CreateEvent()
    {
        Plant plantObject = DeterminePlantType("harvest");
        string eventDate = GetDate();

        Console.Write($"How much did you harvest? (Please enter a number): ");
        int yield = int.Parse(Console.ReadLine());
        
        bool? harvestAgain = null;
        while (harvestAgain == null)
        {
            Console.Write("Will you be able to harvest more of this plant again later? ");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                harvestAgain = true;
            }
            else if (response.ToLower() == "no")
            {
                harvestAgain = false;
            }
            else
            {
                Console.Write("Please enter yes or no: ");
            }
        }
        HarvestingEvent p = new HarvestingEvent(plantObject, eventDate, yield, harvestAgain);
        return p;
    }

    public override string ToString()
    {
        string displayEvent = $@"
Date: {_eventDate} -
    {_name}: {_plantType.GetName()}
    Yield: {_yield} {_plantType.GetName()}
    Can Harvest Again? {HarvestAgain()}
";
        return displayEvent;
    }

    public override string Serialize()
    {
       return base.Serialize() + $"|{_yield}|{_harvestAgain}";
    }

    public static HarvestingEvent Deserialize(string line)
    {
        string[] parts = line.Split("|");

        HarvestingEvent h;
        if (parts[0] == "Harvested")
        {
            Plant plantName = Lookup(parts[1]);
            h = new HarvestingEvent(plantName, parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
        }
        else 
        {
            throw new Exception();
        }
        return h;
    }
    public string HarvestAgain()
    {
        if ((bool)_harvestAgain)
        {
            return "Yes";
        }
        else 
        {
            return "No";
        }
    }
}