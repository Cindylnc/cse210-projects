using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        /*  STEP 1
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
        }*/
    
        /* STEP 2
            Console.Write("What is the magic number? ");
            string response = Console.ReadLine();
            int magicNumber = int.Parse(response);*/

        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1,101);
        
        /*Console.WriteLine($"(**This is it: {magicNumber} **)");*/
        int userGuess = 0;

        do
        {
            Console.Write ("What is your guess? ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);
            
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
        }while (userGuess != magicNumber);
        

    }
}