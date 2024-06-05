using System;

public class Activity
{
    private DateTime _activityDate;
    protected int _activityLengthMinutes;

    public Activity(DateTime activityDate, int activityLengthMinutes)
    {
        _activityDate = activityDate;
        _activityLengthMinutes = activityLengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_activityDate.ToString("dd MMM yyyy")} {GetType().Name} ({_activityLengthMinutes} min) - " + 
            $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}