public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, int points) : base(name, points) {}

    
    public override int RecordEvent()
    {
       
        return GetPoints();
    }

    
    public override string DisplayGoal()
    {
        return $"[∞] {GetName()} ({GetPoints()} points per completion)";
    }
}
