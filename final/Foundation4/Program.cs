using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 5, 1), 30, 3.0),
            new Cycling(new DateTime(2024, 5, 2), 45, 20.0),
            new Swimming(new DateTime(2024, 5, 3), 40, 50)
        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}