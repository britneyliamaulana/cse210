using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool complete = false)
        : base(name, description, points)
    {
        _isComplete = complete;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}
