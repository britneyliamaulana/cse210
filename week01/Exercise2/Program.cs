using System;

// Ask the user for their grade percentage
Console.Write("What is your grade percentage? ");
string input = Console.ReadLine();

// Convert the input to a number
int gradePercentage = int.Parse(input);

// Create a variable to store the letter grade
string letter;

// Determine the letter grade
if (gradePercentage >= 90)
{
    letter = "A";
}
else if (gradePercentage >= 80)
{
    letter = "B";
}
else if (gradePercentage >= 70)
{
    letter = "C";
}
else if (gradePercentage >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

// Print the letter grade
Console.WriteLine($"Your letter grade is: {letter}");

// Check if the student passed
if (gradePercentage >= 70)
{
    Console.WriteLine("Congratulations! You passed the course.");
}
else
{
    Console.WriteLine("Better luck next time.");
}
