// The Program class will display a menu to the user and then 
//      display the Scripture, as well as call on Scripture to re-display the
//      scripture with words missing each time until all the words are hidden.
// For exceeding requirements, the user can choose to display the scripture,
//      or have a list of scriptures displayed to them and then pick one of those to 
//      work on memorizing.

using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

class Program
{
    private static Scripture _currentScripture = Scripture.GetScripturesList()[0];
    static void Main(string[] args)
    {
        // This will clear the console to start with a 
        // fresh console before displaying the Menu or the Scripture
        Console.Clear();
        Menu();
        
    }

    static void Menu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine();
        Console.WriteLine("1. Display scripture");
        Console.WriteLine("2. Choose from scripture list");
        Console.WriteLine("3. Quit");
        Console.WriteLine();
        Console.Write("What would you like to do? ");

        string response = Console.ReadLine();
        switch (response)
        {
            case "1": 
                MemorizeScripture();
                break;
            case "2":
                Console.Clear();
                List<Scripture> scriptureList = Scripture.GetScripturesList();

                for (int i = 0; i < scriptureList.Count; i++)
                {
                    Reference reference = scriptureList[i].GetReference();
                    Console.Write($"{i+1}. ");
                    reference.Display();
                    Console.WriteLine();                
                }
                Console.WriteLine();
                Console.Write("Which number would you like to work on: ");
                int chosenScripture = int.Parse(Console.ReadLine())-1;

                _currentScripture = scriptureList[chosenScripture];
                MemorizeScripture();
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("Goodbye");
                return;
        }
    }

    static void MemorizeScripture()
    {
        Console.Clear();
        while (!_currentScripture.IsAllHidden())
        {
            Console.Clear();
            _currentScripture.Display();
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'Menu' to return: ");
            string userResponse = Console.ReadLine();

            if (userResponse is "Menu" or "menu")
            {
                Console.Clear();
                Menu();
            }
            else
            {
                _currentScripture.HideWords();
            }
        }
        Console.Clear();
        _currentScripture.Display();
    }
}