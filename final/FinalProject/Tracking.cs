using System;
using System.Collections.Generic;
using System.IO;

public static class Tracking
{
    private static List<Plant> _plantDirectory;
    private static List<Plant> _userPlants;
    private static List<GardenEvent> _userSchedule = new List<GardenEvent>();

    public static void DisplayPlantDirectory(List<Plant> plantList)
    {
        for (int i = 0; i < plantList.Count(); i++)
        {
            Console.WriteLine(plantList[i]);
        }
    }

    public static List<Plant> CreateUserPlants()
    {
        return _userPlants;
    }

    public static GardenEvent RecordEvent()
    {
        GardenEvent eventType = null; 
        while (eventType == null)
        {
            Console.Write(@"Which event do you want to record:
    1 - Planting
    2 - Watering
    3 - Pruning
    4 - Harvesting
- ");
            string response = Console.ReadLine();
            if (response == "1")
            {
                PlantingEvent pl = PlantingEvent.CreateEvent();
                eventType = pl;
            }
            else if (response == "2")
            {
                WateringEvent wa = WateringEvent.CreateEvent();
                eventType = wa;
            }
            else if (response == "3")
            {
                PruningEvent pr = PruningEvent.CreateEvent();
                eventType = pr;
            }
            else if (response == "4")
            {
                HarvestingEvent ha = HarvestingEvent.CreateEvent();
                eventType = ha;
            }
            else 
            {
                Console.WriteLine("Please enter 1, 2, 3, or 4: ");
            }
        }
        return eventType;
    }
    public static void CreateUserSchedule()
    {
        // Console.Write("Enter the name for your Garden Schedule: ");
        // string name = Console.ReadLine() + ".txt";

        GardenEvent g = RecordEvent();
        _userSchedule.Add(g);    
    }

    public static void DisplaySchedule()
    {
        for (int i = 0; i < _userSchedule.Count; i++)
        {
            Console.WriteLine(_userSchedule[i]);
        }
    }

    // Need to come back and fill this in later, needs to return a Plant
    public static void Deserialize(string line)
    {
        
    }
    // Will fill this in later-
    public static string Serialize()
    {
        string serialize = "Fix this";
        return serialize;
    }
}