using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTile = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTile = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        /*Console.WriteLine(job1._company);*/
        /*Console.WriteLine(job2._company);*/

        /*string full = job1.DisplayJobDetails();
        Console.WriteLine(full);*/

        /*Console.WriteLine(job1.DisplayJobDetails());
        Console.WriteLine(job2.DisplayJobDetails());*/

        Resume person1 = new Resume();
        person1._name = "Allison Rose";

        /****Console.WriteLine(person1._jobDetails[0]._jobTile);****/

        person1._jobDetails.Add(job1);
        person1._jobDetails.Add(job2);

        person1.Display();









    }
}