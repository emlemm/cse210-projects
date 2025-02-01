// The Entry class stores the data from each entry, and 
// generates a date for each entry, and
// displays the entry.
using System;

public class Entry
{
    public string _prompt;
    public string _entry;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entry);
        Console.WriteLine("");
    }

    public string GenerateDate()
    {
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        return dateText;
    }
}