using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}