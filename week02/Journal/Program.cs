using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Random rand = new Random();
                    string prompt = prompts[rand.Next(prompts.Length)];
                    Console.WriteLine($"Prompt: {prompt}");

                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Console.Write("Enter tags (comma-separated): ");
                    string tagInput = Console.ReadLine();

                    // Declare and initialize 'tags' for use.
                    List<string> tags = new List<string>(tagInput.Split(','));

                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    // 'tags' now exists in this scope
                    journal.AddEntry(new Entry(prompt, response, date, tags));
                    break;


                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
