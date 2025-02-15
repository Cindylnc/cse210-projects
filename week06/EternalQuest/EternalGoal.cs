public class EternalGoal: Goal
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints) 
        : base(goalName, goalDescription, goalPoints)
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Progress made on eternal goal: {_goalName}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal| {_goalName}|{_goalDescription}|{_goalPoints}";
    }

}