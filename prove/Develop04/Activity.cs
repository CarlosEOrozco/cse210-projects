using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        
        Console.WriteLine($"Starting {_name} activity. {_description}");
        Console.WriteLine($"This activity will last for {_duration} seconds. Prepare to begin...");
        Thread.Sleep(3000);
        ShowCountDown(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Thread.Sleep(1000);
        ShowCountDown(3);
        Console.WriteLine($"You have completed the {_name} activity which lasted for {_duration} seconds.");
        Thread.Sleep(1000);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        int left = Console.CursorLeft;
        int top = Console.CursorTop;
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(left, top);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(left, top);
        }
    }

    public abstract void Run();
}
