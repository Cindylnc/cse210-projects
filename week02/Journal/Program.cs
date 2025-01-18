using System;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
     

        //Create prompGenerator object
        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        string userResponse = Console.ReadLine();
        
        //Get the current Date
        DateTime theCurrentDate = DateTime.Now;
        string dateText = theCurrentDate.ToShortDateString();

        //Create a new Entry object
        Entry newEntry = new Entry
        {
            _date = dateText,
            _promptText = randomPrompt,
            _entryText = userResponse,
        };

        //Create journal object
        Journal journal = new Journal ();
        journal.AddEntry(newEntry);
        

        
        Console.WriteLine("\nWelcome to the Journal Program!");
        string menu;
        do
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menu = Console.ReadLine();
            if (menu == "1")
            {

            }
            else if (menu == "2")
            {

            }
            else if (menu == "3")
            {

            }
            else if (menu == "4")
            {

            }
            else if (menu == "5")
            {
                Console.WriteLine("See ya next time!");
            }
            else
            {
                Console.WriteLine("That's not an option");
            }
            Console.WriteLine();


        }
        while (menu !="5");


    }
}