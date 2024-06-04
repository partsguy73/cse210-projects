using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string rsvpEmail)
        : base(title, description, eventDate, eventTime, eventAddress)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}