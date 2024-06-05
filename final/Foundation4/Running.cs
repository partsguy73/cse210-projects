using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime activityDate, int activityLengthMinutes, double distance) : base(activityDate, activityLengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _activityLengthMinutes * 60;
    }

    public override double GetPace()
    {
        return _activityLengthMinutes / _distance; 
    }
}