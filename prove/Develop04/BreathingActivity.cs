public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        int cycles = _duration / 8; // Each cycle lasts for 8 seconds
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4); // countdown for 4 seconds
            Console.WriteLine("Breathe out...");
            ShowCountDown(4); // countdown for 4 seconds
        }
        DisplayEndingMessage();
    }
}