using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflecting");
            Console.WriteLine("4. Exit");
            string choice = Console.ReadLine();
            int duration;
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please enter the duration in seconds:");

                    if (!int.TryParse(Console.ReadLine(), out duration))
                    {
                        Console.WriteLine("Invalid duration. Please try again.");
                        continue;
                    }
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration);
                    breathingActivity.Run();
                    break;
                case "2":
                    Console.WriteLine("Please enter the duration in seconds:");
                    if (!int.TryParse(Console.ReadLine(), out duration))
                    {
                        Console.WriteLine("Invalid duration. Please try again.");
                        continue;
                    }
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration);
                    listingActivity.Run();
                    break;
                case "3":
                    Console.WriteLine("Please enter the duration in seconds:");
                    if (!int.TryParse(Console.ReadLine(), out duration))
                    {
                        Console.WriteLine("Invalid duration. Please try again.");
                        continue;
                    }
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration);
                    reflectingActivity.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

    }
}