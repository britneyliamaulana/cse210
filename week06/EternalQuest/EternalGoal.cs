using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override bool IsComplete()
    {
        return false; // Eternal goals never complete
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}
