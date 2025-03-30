using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Menu();
    }

    static void Menu()
    {
        Console.Write($@"
Menu Options:
    1. View Plant Directory
    2. View Gardening Schedule 
    3. Create New Gardening Schedule
    4. Edit Existing Gardening Schedule
    5. Exit
Select a choice from the Menu: ");

        string response = Console.ReadLine();
        switch (response)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
                Console.Clear();
                break;
        }
    }
}