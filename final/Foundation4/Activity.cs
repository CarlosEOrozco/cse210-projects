public abstract class Activity
{
    private DateTime _date;
    private int _length; // Length in minutes
    protected DateTime Date { get { return _date; } }
    protected int Length { get { return _length; } }
    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {this.GetType().Name} ({Length} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}