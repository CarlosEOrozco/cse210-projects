public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    protected string Title { get { return _title; } }
    protected string Description { get { return _description; } }
    protected DateTime Date { get { return _date; } }
    protected string Time { get { return _time; } }
    protected Address Address { get { return _address; } }
    public string GetStandardDetails()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
    }
    public abstract string GetFullDetails();
    public string GetShortDescription()
    {
        return $"{this.GetType().Name}: {Title} on {Date.ToShortDateString()}";
    }
}