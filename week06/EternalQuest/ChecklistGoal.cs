using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            return GetPoints() + _bonus;
        }

        return GetPoints();
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
