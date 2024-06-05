using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime activityDate, int activityLengthMinutes, int laps) : base(activityDate, activityLengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0; 
    }

    public override double GetSpeed()
    {
        return (_laps * 50.0 / 1000.0) * 0.62 / (_activityLengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return _activityLengthMinutes / (_laps * 50.0 / 1000.0);
    }
}