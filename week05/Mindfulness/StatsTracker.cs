using System;

public class StatsTracker
{
    public int BreathingCount { get; private set; }
    public int ReflectionCount { get; private set; }
    public int ListingCount { get; private set; }

    public void IncrementBreathing() => BreathingCount++;
    public void IncrementReflection() => ReflectionCount++;
    public void IncrementListing() => ListingCount++;

    public void DisplayStats()
    {
        Console.WriteLine("\n===== SESSION STATS =====");
        Console.WriteLine($"Breathing Activities:  {BreathingCount}");
        Console.WriteLine($"Reflection Activities: {ReflectionCount}");
        Console.WriteLine($"Listing Activities:    {ListingCount}");
        Console.WriteLine("===========================");
        Console.WriteLine("Press ENTER to continue...");
        Console.ReadLine();
    }
}
