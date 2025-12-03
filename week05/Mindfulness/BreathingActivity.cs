using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. " +
               "Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        StartMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(4);

            if (DateTime.Now >= endTime) break;

            Console.WriteLine("Breathe out...");
            Countdown(4);
        }

        EndMessage();
    }
}
