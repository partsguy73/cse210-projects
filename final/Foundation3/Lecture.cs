using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string speaker, int capacity)
        : base(title, description, eventDate, eventTime, eventAddress)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}