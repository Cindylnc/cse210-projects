/*Exceeding Requirements: I added the logic to ensure my program randomly selects and hides words 
only from those that are not already hidden. This logic was added in my Scripture.cs file, within the HideRandomWords method. 
In this method, the program filters out words that are already hidden, creating a new list of only visible words. 
Then, it randomly selects from this list to hide the specified number of words.*/


using System;
using System.Diagnostics;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        //Word w = new Word ("truth");
        //Console.WriteLine(w.GetDisplayText());

        Reference reference = new Reference("Proverbs", 3, 5,6);
        Scripture scripture = new Scripture(reference, "Trust the Lord with all thine heart and lean not unto thine own understanding");
       

        //loop
            //display, hide, check if we need to quit
            // Use the functions in the Scripture class.

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
;        }

    }
}