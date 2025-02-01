// Program will open the menu, which the user will use to choose an action
// Program uses Prompts class to display a prompt to the user
// Program creates an Entry and adds it to a Journal object

using System;
using System.IO;
class Program
{
    static Prompts _journalPrompts = new Prompts();
    static Journal _currentJournal = new Journal();
    static void Main(string[] args)
    {
        _journalPrompts._promptList.Add("Who was the most interesting person I interacted with today?");
        _journalPrompts._promptList.Add("What was the best part of my day?");
        _journalPrompts._promptList.Add("How did I see the hand of the Lord in my life today?");
        _journalPrompts._promptList.Add("What was the strongest emotion I felt today?");
        _journalPrompts._promptList.Add("If I had one thing I could do over today, what would it be?");
        _journalPrompts._promptList.Add("What is one thing I accomplished today that I am proud of?");
        _journalPrompts._promptList.Add("What made today a good day?");
        _journalPrompts._promptList.Add("How was I a kind person today?");
        _journalPrompts._promptList.Add("How could I be a better person tomorrow?");
        _journalPrompts._promptList.Add("Who is somebody that I can help tomorrow?");
        _journalPrompts._promptList.Add("What was the best thing that I ate today?");
        
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        string response = Console.ReadLine();
        switch (response)
        {
            case "1": 
                WriteEntry();
                Menu();
                break;
            case "2":
                _currentJournal.Display();
                Menu();
                break;
            case "3":
                LoadJournal();
                Menu();
                break;
            case "4":
                SaveJournal();
                Menu();
                break;
            case "5":
                return;
        }
    }

    static void WriteEntry()
    {        
        Entry entry = new Entry();

        string userPrompt = _journalPrompts.GetRandomPrompt();
        Console.WriteLine(userPrompt);

        entry._entry = Console.ReadLine();
        entry._prompt = userPrompt;
        entry._date = entry.GenerateDate();

        _currentJournal.AddEntry(entry);
    }

    static void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        _currentJournal = Journal.Load(fileName);
    }

    static void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        _currentJournal.SaveJournal(fileName);
    }
}