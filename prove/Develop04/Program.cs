using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity testActivity = new BreathingActivity();
        testActivity.LaunchActivity();
        //testActivity.CountdownTimer(5);
        //Thread.Sleep(1000);
        //testActivity.LoadingAnimation(8);

        //testActivity.LaunchActivity();
    }

    public static void Menu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");

        // string response = Console.ReadLine();
        // Console.Clear();
        // switch (response)
        // {
        //     case "1":
        //         BreathingActivity breathing = new BreathingActivity();
        //         breathing.LaunchActivity();
        //         break;
        //     case "2":
        //         ReflectingActivity reflecting = new ReflectingActivity();
        //         break;
        //     case "3":
        //         ListingActivity listing = new ListingActivity();
        //         break;
        //     case "4":                
        //         Console.WriteLine("Goodbye");
        //         return;
        // }
    }
}