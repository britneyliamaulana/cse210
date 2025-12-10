using System;

class Running : Activity
{
    private double _distance; // in km

    public Running(DateTime date, double lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / LengthInMinutes) * 60;

    public override double GetPace() => LengthInMinutes / _distance;
}
