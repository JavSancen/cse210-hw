using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return (laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return LengthInMinutes / distance;
    }
}