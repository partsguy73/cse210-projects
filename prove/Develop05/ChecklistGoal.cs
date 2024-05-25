using System;


public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
            return _points + _bonus;
        }
        return _points;
    }

    public override string GetDetailsString()
    {
        return $"{_name} - {_description} - Completed {_amountCompleted}/{_target} times {(_isComplete ? "[x]" : "[ ]")}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_name}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}|{_isComplete}";
    }

    public override void LoadDetails(string[] goalData)
    {
        _amountCompleted = int.Parse(goalData[3]);
        _target = int.Parse(goalData[4]);
        _bonus = int.Parse(goalData[5]);
        _isComplete = bool.Parse(goalData[6]);
    }
}