using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public override void Run()
    {
        StartMessage();

        Random rnd = new Random();
        Console.WriteLine("\nList as many responses as you can to this prompt:");
        Console.WriteLine($"--- {_prompts[rnd.Next(_prompts.Count)]} ---");

        Console.WriteLine("\nYou may begin in: ");
        Countdown(5);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndMessage();
    }
}
