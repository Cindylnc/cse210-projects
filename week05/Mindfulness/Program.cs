using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("MINDFULNESS ACTIVITIES");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting  Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice =="1")
            {
                new BreathingActivity().Run();
            }
            else if (choice =="2")  
            {
                new ReflectingActivity().Run();
            }
            else if (choice =="3")  
            {
                new ListingActivity().Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again");
            }
        }
    }
}