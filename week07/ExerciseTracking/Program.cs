using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine("");

        List<Activity> activites = new List<Activity>
        {
            new Running ("18 Feb 2022", 30, 3.0),
            new Biking ("15 Feb 2025", 30, 12.0),
            new Swimming("15 Feb 2025", 35, 20)
        };

        foreach (var activity in activites)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("");
    }
}