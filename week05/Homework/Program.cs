using System;

class Program
{
    static void Main(string[] args)
    {
        StatsTracker stats = new StatsTracker();
        int choice = -1;

        while (choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Stats");
            Console.WriteLine("5. Quit");
            Console.Write("\nChoose an option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1;
            }

            switch (choice)
            {
                case 1:
                    new BreathingActivity().Run();
                    stats.IncrementBreathing();
                    break;

                case 2:
                    new ReflectionActivity().Run();
                    stats.IncrementReflection();
                    break;

                case 3:
                    new ListingActivity().Run();
                    stats.IncrementListing();
                    break;

                case 4:
                    stats.DisplayStats();
                    break;

                case 5:
                    Console.WriteLine("\nGoodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Press ENTER to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
