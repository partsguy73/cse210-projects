using System;

public class OutdoorGathering : Event
{
    private string _weatherStatement;
    public OutdoorGathering(string title, string description, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string weatherStatement)
        : base(title, description, eventDate, eventTime, eventAddress)
    {
        _weatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather: {_weatherStatement}";
    }
}

