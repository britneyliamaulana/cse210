using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    // Default version – only overridden by ChecklistGoal
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }

    public abstract bool IsComplete();
    public abstract int RecordEvent();
    public abstract string GetStringRepresentation();
}
