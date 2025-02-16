// The Scripture class will store a list of Word(s) that is associated 
//      with a Reference and display the Reference and words of the scripture. 
// The Scripture class also stores a list of Scripture(s) 
//      that the user can choose from to display.
// The Scripture class will also hide words and re-display the Reference 
//      and words with some words hidden when prompted.

using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();

    private List<Word> _displayedWords = new List<Word>();

    private static List<Scripture> _scripturesList = Load("ListOfScriptures.txt");

    public Scripture(Reference reference, string textOfScripture)
    {
        _reference = reference;

        string[] words = textOfScripture.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        } 
    }
    private static Scripture Deserialize(string line)
    {
        string[] parts = line.Split("|");
        string[] verseParts = parts[2].Split("-");

        Reference reference;
        if (verseParts.Length == 1)
        { 
            reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(verseParts[0]));
        }
        else 
        {
            reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(verseParts[0]), int.Parse(verseParts[1]));
        }

        return new Scripture(reference, parts[3]);
    }

    private static List<Scripture> Load(string fileName)
    {
        List<Scripture> scriptureList = new List<Scripture>();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Scripture scripture = Deserialize(line);
            scriptureList.Add(scripture);
        }
        return scriptureList;
    }

    public static List<Scripture> GetScripturesList()
    {
        return _scripturesList;
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public void Display()
    {
        _reference.Display();
        foreach (Word word in _words)
        {
            word.Display();
        }
        Console.WriteLine("");
    }

    public void HideWords()
    {
        int numOfRemovedWords = GenerateRandomInt(3,5);
        for (int i = 0; i < numOfRemovedWords && !IsAllHidden(); i++)
        {
            int indexToHide;
            do
            {
                indexToHide = GenerateRandomInt(0, _words.Count-1);
            } while (_words[indexToHide].IsHidden());

            _words[indexToHide].Hide();
        }
    }
    
    private int GenerateRandomInt(int first, int second)
    {
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(first, second+1);
        return randNumber;
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
