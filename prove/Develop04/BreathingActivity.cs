using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public override void LaunchActivity()
    {
        base.LaunchActivity();
        Console.WriteLine();
        
        int iterations = _time/10;
        for (int i = iterations; i > 0; i--)
        {
            Console.Write("Breathe in...");
            base.CountdownTimer(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            base.CountdownTimer(5);
            Console.WriteLine();
            Console.WriteLine();
        }
        base.EndMessage();
    }
}