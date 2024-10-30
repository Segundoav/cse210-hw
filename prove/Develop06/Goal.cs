using System;

public abstract class Goal
{
    // Attributes
    private string _name;
    private int _points;
    private bool _isComplete;

    // Constructor
    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    // Methods
    public string GetName() => _name;
    public int GetPoints() => _points;
    public bool IsComplete() => _isComplete;

    public void MarkAsComplete()
    {
        _isComplete = true;
    }

    
    public abstract int RecordEvent();

    public abstract string DisplayGoal();
}
