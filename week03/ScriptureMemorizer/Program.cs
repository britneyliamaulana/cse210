using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // User selects a scripture from a list
        Scripture scripture = ChooseScripture();

        // User selects difficulty level
        int hideCount = SelectDifficulty();

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine($"Difficulty: hiding {hideCount} word(s) per step.");
            Console.WriteLine("Press ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(hideCount);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Goodbye!");
                break;
            }
        }
    }

    // -----------------------------
    // Choose a scripture from a list
    // -----------------------------
    static Scripture ChooseScripture()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths."
            ),

            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth " +
                "in him should not perish, but have everlasting life."
            ),

            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd; I shall not want."
            ),

            new Scripture(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."
            )
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose a scripture to memorize:\n");

            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {scriptures[i].ReferenceText}2");
            }

            Console.Write("\nEnter choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) &&
                choice >= 1 &&
                choice <= scriptures.Count)
            {
                return scriptures[choice - 1];
            }

            Console.WriteLine("\nInvalid choice. Press Enter to try again.");
            Console.ReadLine();
        }
    }

    // -----------------------------
    // Difficulty selection
    // -----------------------------
    static int SelectDifficulty()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select a difficulty:");
            Console.WriteLine("1 - Easy (hide 1 word at a time)");
            Console.WriteLine("2 - Medium (hide 3 words at a time)");
            Console.WriteLine("3 - Hard (hide 5 words at a time)");
            Console.WriteLine("4 - Extreme (hide 10 words at a time)");
            Console.Write("\nEnter choice: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1": return 1;
                case "2": return 3;
                case "3": return 5;
                case "4": return 10;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
