using System;

public class ListingActivity : Activity
{
    private List<string> _promptsList = Prompt.Load("ListingPrompts.txt");
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

    public override void LaunchActivity()
    {
        base.LaunchActivity();
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        string prompt = Prompt.GetRandomPrompt(_promptsList);
        Console.WriteLine($"\n --- {prompt} ---");
        Console.Write("\nYou may begin in: ");
        base.CountdownTimer(5);
        Console.WriteLine();
        
        DateTime futureTime = DateTime.Now.AddSeconds(_time);

        int numResponses = 0;
        while (futureTime > DateTime.Now)
        {
            Console.Write("> ");
            string userResponse = Console.ReadLine();
            numResponses +=1;
        }

        Console.WriteLine($"\nYou listed {numResponses} items!\n");
        base.EndMessage();
    }

}