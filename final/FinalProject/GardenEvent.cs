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
        return $"{_name}|{_plantType}|{_eventDate}";
    }

    public static string GetDate()
    {
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        Console.Write("Was this today?");
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