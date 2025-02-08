using System.Diagnostics.CodeAnalysis;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}


    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);

            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }

        DisplayEndingMessage();

    }
}