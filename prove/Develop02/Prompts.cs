// The Prompts class stores a list of strings that are prompts and displays a random prompt

using System;
using System.Collections.Generic;
public class Prompts
{
    public List<string> _promptList = new List<string>();
    //_promptList.Add
    public int _randomInt;

    public string GetRandomPrompt() 
    {   
        _randomInt = GenerateRandomInt();
        return _promptList[_randomInt];
    }

    public int GenerateRandomInt()
    {
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, _promptList.Count);
        return randNumber;
    }
}