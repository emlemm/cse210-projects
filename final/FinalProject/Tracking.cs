using System;
using System.Collections.Generic;
using System.IO;

public static class Tracking
{
    private static List<Plant> _plantDirectory = GetPlantDirectory("PlantDirectory.txt");
    private static List<GardenEvent> _userSchedule = new List<GardenEvent>();

    public static void DisplayPlantDirectory(List<Plant> plantList)
    {
        for (int i = 0; i < plantList.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {plantList[i].GetDescription()}");
        }
    }

    public static GardenEvent RecordEvent()
    {
        GardenEvent eventType = null; 
        while (eventType == null)
        {
            Console.WriteLine();
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
    
    public static void ClearSchedule()
    {
        _userSchedule.Clear();
    }
    public static void EditSchedule()
    {
        string fileName = Console.ReadLine();
        Console.Write("Do you want to add an event to the schedule? ");
        string addingEvent = Console.ReadLine();
        while (addingEvent.ToLower() == "yes")
        {
            AddEventsToList();
            Console.Write("Would you like to add another event? \n");
            addingEvent = Console.ReadLine();
        }
        SaveToFile(fileName);
    }
    
    public static void DisplaySchedule(List<GardenEvent> eventList)
    {
        for (int i = 0; i < eventList.Count; i++)
        {
            Console.WriteLine(eventList[i]);
        }
    }
    public static void AddEventsToList()
    {
        GardenEvent g = RecordEvent();
        _userSchedule.Add(g);    
    }

    public static void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (GardenEvent g in _userSchedule)
            {
                outputFile.WriteLine(g.Serialize());
            }
        }
    }

    public static List<GardenEvent> LoadFromFile(string fileName)
    {
        List<GardenEvent> schedule = new List<GardenEvent>();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            GardenEvent g = null;
            if (parts[0] == "Planted")
            {
                g = PlantingEvent.Deserialize(line);
                schedule.Add(g);
            }
            else if (parts[0] == "Watered")
            {
                g = WateringEvent.Deserialize(line);
                schedule.Add(g);
            }
            else if (parts[0] == "Pruned")
            {
                g = PruningEvent.Deserialize(line);
                schedule.Add(g);
            }
            else if (parts[0] == "Harvested")
            {
                g = HarvestingEvent.Deserialize(line);
                schedule.Add(g);
            }
        }
        return schedule;
    }

    public static List<Plant> GetPlantDirectory(string fileName)
    {
        List<Plant> plants = new List<Plant>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        foreach (string l in lines)
        {
            Plant p = Plant.Deserialize(l);
            plants.Add(p);
        }
        return plants;
    }

    public static List<Plant> GetPlantList()
    {
        return _plantDirectory;
    }

}