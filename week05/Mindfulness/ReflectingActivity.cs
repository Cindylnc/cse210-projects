public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."

    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?"
    };


    public ReflectingActivity()
       : base("Reflection Activity", "This activity helps you reflect on moments of strength and resilience"){}

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Prompt: " + GetRandomPrompt());
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Question: " + GetRandomQuestion());
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }
    //public void DisplayPrompt()
    //{}
    //public void DisplayQuestions()
    //{}
}