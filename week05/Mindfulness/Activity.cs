public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
       Console.Clear();
       Console.WriteLine($"Starting {_name}...");
       Console.WriteLine(_description);
       Console.WriteLine("Enter duration (in seconds): ");

       _duration = int.Parse(Console.ReadLine());
       Console.WriteLine("Prepare to begin..");
       ShowSpinner(10);

    }

    public void DisplayEndingMessage() 
    {
        Console.WriteLine("Good Job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} for {_duration}seconds.");
    }

    public void ShowSpinner(int seconds)
    {


        char[] spinner = {'/','-','\\','|'};
        int i = 0;
        
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(300);
            Console.Write("\b\b");
            i = (i + 1) % 4;
        }        /*for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine("/");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.WriteLine("-");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.WriteLine("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.WriteLine("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }*/
        
    }


    public void ShowCountDown(int seconds)
    {
        for (int i=seconds; i > 0; i--)
        {
            Console.WriteLine(i + "");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();

    }

}