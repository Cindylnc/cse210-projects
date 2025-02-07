using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment a1= new Assignment("Carlos Ramirez", "Geometry");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine("");

        MathAssignment a2 = new MathAssignment("Jack Sanz", "Polygons", "4.5", "9-12");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment a3 = new WritingAssignment("Melanie Stephens", "World History", "The Great Encyclopedia");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}