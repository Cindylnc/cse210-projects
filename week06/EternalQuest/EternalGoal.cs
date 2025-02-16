public class EternalGoal: Goal
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints) 
        : base(goalName, goalDescription, goalPoints)
    {
        
    }

    public override int RecordEvent()
    {
        return GetGoalPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[-] {GetGoalName()} ({GetGoalDescription()})";
    }


    public override string GetStringRepresentation()
    {
        return $"Eternal Goal|{GetGoalName}|{GetGoalDescription()}|{GetGoalPoints()}";
    }

}