using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime activityDate, int activityLengthMinutes, double speed) : base(activityDate, activityLengthMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * (_activityLengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }
}