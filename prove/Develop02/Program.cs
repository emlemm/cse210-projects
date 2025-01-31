// Program will open the menu, which the user will use to choose an action
// Program uses Prompts class to display a prompt to the user
// Program creates an Entry and adds it to a Journal object

using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Prompts journalPrompts = new Prompts();
        journalPrompts._promptList.Add("Who was the most interesting person I interacted with today?");
        journalPrompts._promptList.Add("What was the best part of my day?");
        journalPrompts._promptList.Add("How did I see the hand of the Lord in my life today?");
        journalPrompts._promptList.Add("What was the strongest emotion I felt today?");
        journalPrompts._promptList.Add("If I had one thing I could do over today, what would it be?");
        journalPrompts._promptList.Add("What is one thing I accomplished today that I am proud of?");
        journalPrompts._promptList.Add("What made today a good day?");
        journalPrompts._promptList.Add("How was I a kind person today?");
        journalPrompts._promptList.Add("How could I be a better person tomorrow?");
        journalPrompts._promptList.Add("Who is somebody that I can help tomorrow?");
        journalPrompts._promptList.Add("What was the best thing that I ate today?");

        journalPrompts.DisplayPrompt();
    }
}