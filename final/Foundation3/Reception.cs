public class Reception : Event
{
    private string _rsvp;
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvp)
        : base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP: {_rsvp}";
    }
}