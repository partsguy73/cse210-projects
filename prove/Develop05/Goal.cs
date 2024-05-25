using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract int RecordEvent();

    public virtual string GetDetailsString()
    {
        return $"{_name} - {_description} - {(_isComplete ? "[x]" : "[ ]")}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_name}|{_description}|{_points}|{_isComplete}";
    }

    public virtual void LoadDetails(string[] goalData)
    {
        _isComplete = bool.Parse(goalData[3]);
    }
}