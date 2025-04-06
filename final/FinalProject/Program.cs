using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu();
    }

    static void Menu()
    {
        Console.Write($@"
Menu Options:
    1. View Plant Directory
    2. Create New Gardening Schedule
    3. Edit Existing Gardening Schedule
    4. View Gardening Schedule
    5. Exit
Select a choice from the Menu: ");

        string response = Console.ReadLine();
        switch (response)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("\nPlant Directory: \n");
                Tracking.DisplayPlantDirectory(Tracking.GetPlantList());
                Console.Write("When ready to return to menu, press enter: ");
                Console.ReadLine();
                Console.Clear();
                Menu();
                break;

            case "2":
                Console.Clear();
                Console.Write("What is the name for your Garden Schedule? ");
                Tracking.ClearSchedule();
                Tracking.EditSchedule();
                Console.Clear();
                Menu();
                break;

            case "3":
                Console.Clear();
                Console.Write("What is the name of the schedule you want to edit? ");
                Tracking.ClearSchedule();
                Tracking.EditSchedule();
                Console.Clear();
                Menu();
                break;

            case "4":
                Console.Clear();
                Console.Write("What is the name of the schedule you want to view? ");
                string fileName = Console.ReadLine();
                List<GardenEvent> userList = Tracking.LoadFromFile(fileName);
                Tracking.DisplaySchedule(userList);
                Console.Write("When ready to return to menu, press enter: ");
                Console.ReadLine();
                Console.Clear();
                Menu();
                break;

            case "5":
                Console.Clear();
                break;
        }
    }
}