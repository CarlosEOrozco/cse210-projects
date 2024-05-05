public class Entry
{
    public string _promptText { get; set; }
    public string _entryText { get; set; }
    public DateTime _date { get; set; }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date}, Prompt: {_promptText}, Response: {_entryText}");
    }
}