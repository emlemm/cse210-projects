using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

abstract public class GardenEvent
{
    protected string _name;
    protected Plant _plantType;
    protected string _eventDate;

    public GardenEvent(string name, Plant plantType, string eventDate)
    {
        _name = name;
        _plantType = plantType;
        _eventDate = eventDate;
    }

    public virtual string Serialize()
    {
        return $"{_name}|{_plantType.GetName()}|{_eventDate}";
    }

    public static Plant Lookup(string plantName) {
        return Tracking.GetPlantList().Find(x => x.GetName().ToLower() == plantName.ToLower());
    }
    
    public static Plant DeterminePlantType(string eventName)
    {
        bool validPlant = false;
        Plant plantObject = null;
        while (!validPlant)
        {
            Console.Write($"What plant did you {eventName} in your garden? ");
            string userPlant = Console.ReadLine().ToLower();
            plantObject = Lookup(userPlant);

            if (plantObject != null)
            {
                validPlant = true;
            }
            else
            {
                validPlant = false;
                Console.WriteLine("Error: Plant not known. Please check spelling and enter the name of a plant that is found in the Plant Directory.");
            }
        }
        return plantObject;
    }

    public static string GetDate()
    {
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        Console.Write("Was this today? ");
        string response = Console.ReadLine();
        string lowerResponse = response.ToLower();
        if (response == "yes")
        {
            return dateText;
        }
        else 
        {
            Console.Write("Please enter the date for this event (MM/DD/YYYY eg: 01/31/2005): ");
            string editedDate = Console.ReadLine();
            return editedDate;
        }
    }
}