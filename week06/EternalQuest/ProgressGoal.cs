using System;

public class ProgressGoal : Goal
{
    private double _progress;
    private double _target;
    private int _bonus;
    private int _pointsPerUnit;

    public ProgressGoal(string name, string description, int pointsPerUnit, double target, int bonus, double progress = 0)
        : base(name, description, pointsPerUnit)
    {
        _progress = progress;
        _target = target;
        _bonus = bonus;
        _pointsPerUnit = pointsPerUnit;
    }

    public override bool IsComplete()
    {
        return _progress >= _target;
    }

    public override int RecordEvent()
    {
        Console.Write("How much progress did you make? (example: miles/hours/etc): ");
        double amount = double.Parse(Console.ReadLine());

        _progress += amount;

        // Points earned for incremental progress
        int earned = (int)(amount * _pointsPerUnit);

        // If the target is hit exactly THIS event
        if (_progress >= _target && _progress - amount < _target)
        {
            earned += _bonus;
            Console.WriteLine($"Bonus achieved! You earned an additional {_bonus} points!");
        }

        return earned;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) - Progress: {_progress}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ProgressGoal|{GetName()}|{GetDescription()}|{_pointsPerUnit}|{_progress}|{_target}|{_bonus}";
    }
}
