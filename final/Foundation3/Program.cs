using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Event lecture = new Lecture("Tech Talk", "Discussing the latest in tech", new DateTime(2024, 6, 15), "10:00 AM", address1, "John Doe", 100);
        Event reception = new Reception("Networking Event", "Meet and greet with professionals", new DateTime(2024, 6, 20), "6:00 PM", address2, "rsvp@event.com");
        Event outdoorGathering = new OutdoorGathering("Company Picnic", "Annual company picnic with family and friends", new DateTime(2024, 7, 4), "12:00 PM", address1, "Sunny");
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}