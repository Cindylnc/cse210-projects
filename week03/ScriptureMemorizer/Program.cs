using System;
using System.Diagnostics;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Word w = new Word ("truth");
        Console.WriteLine(w.GetDisplayText());

         Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "I will go and do");
       

        //loop
            //display, hide, check if we need to quit
            // Use the functions in the Scripture class.

    }
}