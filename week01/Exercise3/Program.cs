using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the magic number? ");
        string response = Console.ReadLine();
        int magicNumber = int.Parse(response);

        Console.Write ("What is your guess? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);

        if (userGuess > magicNumber)
        {
            Console.WriteLine ("Lower");
        }
        else if (userGuess < magicNumber)
        {
            Console.WriteLine ("Higher");
        }
        else
        {
            Console.WriteLine ("You guessed it!");
        }
    







    }
}