// For exceeding the requirements, Program keeps track of how many times the user 
// has done each activity, and in the Menu there is an option to view those stats.

using System;

class Program
{
    private static int _breathingLog = 0;
    private static int _reflectingLog = 0;
    private static int _listingLog = 0;
    static void Main(string[] args)
    {
        Console.Clear();
        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start Reflecting Activity");
        Console.WriteLine("  3. Start Listing Activity");
        Console.WriteLine("  4. View current session stats");
        Console.WriteLine("  5. Quit");
        Console.Write("Select a choice from the menu: ");

        string response = Console.ReadLine();
        switch (response)
        {
            case "1":
                BreathingActivity breathing = new BreathingActivity();
                _breathingLog += 1;
                breathing.LaunchActivity();
                break;
            case "2":
                ReflectingActivity reflecting = new ReflectingActivity();
                _reflectingLog += 1;
                reflecting.LaunchActivity();
                break;
            case "3":
                ListingActivity listing = new ListingActivity();
                _listingLog += 1;
                listing.LaunchActivity();
                break;
            case "4":
                Console.Clear();
                Console.WriteLine($"You have done the Breathing Activity {_breathingLog} times this session.");
                Thread.Sleep(1500);
                Console.WriteLine($"You have done the Reflecting Activity {_reflectingLog} times this session.");
                Thread.Sleep(1500);
                Console.WriteLine($"You have done the Listing Activity {_listingLog} times this session.");
                Thread.Sleep(1500);
                Console.Write("\nPress enter to return to menu.");
                Console.ReadLine();
                Console.Clear();
                Menu();
                break;
            case "5":
                Console.Clear();                
                Console.WriteLine("Goodbye");
                return;
        }
    }
}