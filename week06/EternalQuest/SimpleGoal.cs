using System.Linq.Expressions;

public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string goalName, string goalDescription, int goalPoints) : base(goalName, goalDescription, goalPoints)
    {
        _isComplete = true;
    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true;
    }

    public string GetStringRepresentation()
    {
        return "";
    }


    

}