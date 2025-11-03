using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
         //1. Ask the user for a list of numbers
         // Keep asking until they enter 0.

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);
        //2. Compute the sum of the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        //3. Compute the average of the numbers
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //4. Find the maximum number in the list
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        //stretch challenge

        List<int> positiveNumbers = numbers.Where(n => n > 0).ToList();
        if (positiveNumbers.Count > 0)
        {
            int smallestPositive = positiveNumbers.Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
