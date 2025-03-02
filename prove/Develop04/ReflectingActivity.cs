using System;

public class ReflectingActivity : Activity
{
    private List<string> _promptsList = Prompt.Load("ReflectingPrompts.txt");
    private List<string> _questionsList = Prompt.Load("DeeperQuestionsList.txt");   
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}

    public override void LaunchActivity()
    {
        base.LaunchActivity();
        Console.WriteLine("\nConsider the following prompt:");
        string prompt = Prompt.GetRandomPrompt(_promptsList);
        Console.WriteLine($"\n --- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.CountdownTimer(5);

        Console.Clear();

        int iterations = _time/10;
        for (int i = iterations; i > 0; i--)
        {
            string question = Prompt.GetRandomPrompt(_questionsList);
            Console.Write($"> {question} ");
            base.LoadingAnimation(10);
            Console.WriteLine();
        }
        Console.WriteLine();
        base.EndMessage();
    }
}