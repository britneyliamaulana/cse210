using System;

class Program
{
    static void Main(string[] args)
    {
        //1.Ask the user for their guess
        //Console.Write("What is your guess? ");
        //int guess = int.Parse(Console.ReadLine());
        //2.loop as long as guess is incorrect

        //3: Replace the user-defined magic number with a random generated one.

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
        Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
        Console.WriteLine("Lower");
        }
        else
        {
        Console.WriteLine("You guessed it!");
        }

    }
}
}

     