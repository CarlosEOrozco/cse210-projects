public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _items = new List<string>();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                _items.Add(item);
            }
        }
        DisplayEndingMessage();
        Console.WriteLine($"You listed {_items.Count} items.");
    }
}