using System;

class Swimming : Activity
{
    private int _laps; // number of laps (50m each)

    public Swimming(DateTime date, double lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50.0) / 1000;

    public override double GetSpeed() => (GetDistance() / LengthInMinutes) * 60;

    public override double GetPace() => LengthInMinutes / GetDistance();
}
