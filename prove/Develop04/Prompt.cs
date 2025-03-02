using System;

public class Prompt
{
    public static List<string> Load(string fileName)
    {
        List<string> promptList = new List<string>();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            promptList.Add(line);
        }
        return promptList;
    }

    public static string GetRandomPrompt(List<string> promptList) 
    {   
        int randomInt = GenerateRandomInt(promptList);
        return promptList[randomInt];
    }

    private static int GenerateRandomInt(List<string> promptList)
    {
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, promptList.Count);
        return randNumber;
    }
}