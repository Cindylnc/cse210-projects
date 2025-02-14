public class EternalGoal: Goal
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints) : base(goalName, goalDescription, goalPoints)
    {
        
    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return false;
    }

    public string GetStringRepresentation()
    {
        return "";
    }







}