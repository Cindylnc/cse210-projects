public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What is something you are grateful for today that you often overlook?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What is something you learned today?",
        "What is one moment today that brought you peace or calm?",
        "How did you connect with others today, even in small ways?",
        "How did you grow or stretch outside your comfort zone today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing that made you smile today?",
        "What challenge did you face today, and how did you handle it?",
        "Who were you the most happy seeing today?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}