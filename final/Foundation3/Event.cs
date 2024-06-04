using System;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _eventDate;
    private TimeSpan _eventTime;
    protected Address _eventAddress;

    public Event(string title, string description, DateTime eventDate, TimeSpan eventTime, Address eventAddress)
    {
        _title = title;
        _description = description;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }
    
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_eventDate.ToShortDateString()}\nTime: {_eventTime}\nAddress: {_eventAddress}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_title}\nDate: {_eventDate.ToShortDateString()}";
    }
}