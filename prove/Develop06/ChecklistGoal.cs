public class ChecklistGoal : Goal
{
    // Additional attributes for checklist goals
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    // Constructor
    
    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    
    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            MarkAsComplete();
            return GetPoints() + _bonusPoints;
        }
        return GetPoints();
    }

    public override string DisplayGoal()
    {
        string status = IsComplete() ? "[X]" : $"[{_currentCount}/{_targetCount}]";
        return $"{status} {GetName()} ({GetPoints()} points, {_bonusPoints} bonus)";
    }
}
