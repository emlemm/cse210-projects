using System;
using System.ComponentModel;
using System.Runtime;

public class WateringEvent : GardenEvent
{
    private string _timeOfDay;
    private string _amount;

    public WateringEvent(Plant plantType, string eventDate, string timeOfDay, string amount) 
    : base("Watered", plantType, eventDate)
    {
        _eventDate = eventDate;
        _timeOfDay = timeOfDay;
        _amount = amount;
    }
    
    public static WateringEvent CreateEvent()
    {
        Plant plantObject = DeterminePlantType("water");
        string eventDate = GetDate();
        
        string time = null;
        while (time == null)
        {   
            Console.Write("What time of day did you water? (1 - Morning, 2 - Afternoon, 3 - Evening): ");
            string response = Console.ReadLine();
            if (response == "1")
            {
                time = "Morning";
            }
            else if (response == "2")
            {
                time = "Afternoon";
            }
            else if (response == "3")
            {
                time = "Evening";
            }
            else 
            {
                Console.WriteLine("Please enter 1, 2, or 3: ");
            }
        }

        string amount = null;
        while (amount == null)
        {   
            Console.Write("How much did you water? (1 - Minimal, 2 - Average, 3 - Deep Soak): ");
            string response = Console.ReadLine();
            if (response == "1")
            {
                amount = "Minimal";
            }
            else if (response == "2")
            {
                amount = "Average";
            }
            else if (response == "3")
            {
                amount = "Deep Soak";
            }
            else 
            {
                Console.WriteLine("Please enter 1, 2, or 3: ");
            }
        }

        WateringEvent w = new WateringEvent(plantObject, eventDate, time, amount);
        return w;
    }

    public override string ToString()
    {
        string displayEvent = $@"
Date: {_eventDate} -
    {_name}: {_plantType.GetName()}
    When: {_timeOfDay}
    Amount: {_amount}
";
        return displayEvent;
    }

    public override string Serialize()
    {
       return base.Serialize() + $"|{_timeOfDay}|{_amount}";
    }

    public static WateringEvent Deserialize(string line)
    {
        string[] parts = line.Split("|");

        WateringEvent w;
        if (parts[0] == "Watered")
        {
            Plant plantName = Lookup(parts[1]);
            if (plantName == null) {
                throw new NullReferenceException();
            }
            w = new WateringEvent(plantName, parts[2], parts[3], parts[4]);
        }
        else 
        {
            throw new Exception();
        }
        return w;
    }
}