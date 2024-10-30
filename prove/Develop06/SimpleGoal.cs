public class SimpleGoal : Goal
{
    // Constructor
    public SimpleGoal(string name, int points) : base(name, points) {}

    
    public override int RecordEvent()
    {
        MarkAsComplete();
        return GetPoints();
    }

    
    public override string DisplayGoal()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetPoints()} points)";
    }
}
