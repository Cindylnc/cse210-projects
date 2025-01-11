using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine ("Enter a list of numbers, type 0 when finished.");
        Console.Write ("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
      
        int sum = 0;
        /*int count = 0;*/

        while (number != 0)
        {        
            numbers.Add(number);
            sum += number;
            /*count++;*/

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }

        float average = ((float)sum) / numbers.Count;
        int largestNumber = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        
       
    }

    

}