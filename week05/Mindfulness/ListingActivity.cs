public class ListingActivity : Activity
{
    //private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity helps you reflect on the good things in life by listing them")
        {}

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Prompt: " + GetRandomPrompt());
        ShowSpinner(3);

        Console.WriteLine("Start listing items:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random= new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    //public List<prompt> GetListFromUser()
    //{}


}