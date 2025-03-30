using System;
using System.Collections.Generic;
using System.IO;

public static class Tracking
{
    private static List<Plant> _plantDirectory;
    private static List<Plant> _userPlants;
    private static List<GardenEvent> _userSchedule;

    public static void DisplayPlantInfo(Plant plant)
    {

    }

    public static List<Plant> CreateUserPlants()
    {
        return _userPlants;
    }

    public static List<GardenEvent> CreateUserSchedule()
    {
        return _userSchedule;
    }

    public static void DisplaySchedule()
    {

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