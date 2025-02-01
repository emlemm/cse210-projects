// The Journal class will load and save entries and 
// will display the contents of the journal by calling Display() on each entry
using System;
using System.IO;
using System.Collections.Generic;

public class Journal 
{
    public List<Entry> _entryList = new List<Entry>();

    public void SaveJournal(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }

    public void AddEntry(Entry entry)
    {
        _entryList.Add(entry);
    }

    public static Journal Load(string fileName)
    {
        Journal journal = new Journal();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];

            journal.AddEntry(entry);
        }
        return journal;
    }

    public void Display()
    {
        foreach(Entry entry in _entryList)
        {
           entry.Display();
        }
    }
}