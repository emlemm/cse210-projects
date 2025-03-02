using System;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");

        string response = Console.ReadLine();
        switch (response)
        {
            case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.LaunchActivity();
                break;
            case "2":
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.LaunchActivity();
                break;
            case "3":
                ListingActivity listing = new ListingActivity();
                listing.LaunchActivity();
                break;
            case "4":
                Console.Clear();                
                Console.WriteLine("Goodbye");
                return;
        }
    }
}