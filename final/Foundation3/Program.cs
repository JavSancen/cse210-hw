using System;

public class Program
{
    public static void Main()
    {
        Address lectureAddress = new Address() { Street = "123 Main St", City = "Anytown", State = "CA", ZipCode = "12345" };
        Event lecture = new Lecture("AI Lecture", "Lecture on AI", DateTime.Now, "10:00 AM", lectureAddress, "Dr. Smith", 100);

        Address receptionAddress = new Address() { Street = "456 Elm St", City = "Othertown", State = "NY", ZipCode = "67890" };
        Event reception = new Reception("Networking Event", "Business networking event", DateTime.Now.AddDays(1), "6:00 PM", receptionAddress, "rsvp@example.com");

        Address outdoorAddress = new Address() { Street = "789 Oak St", City = "Sometown", State = "WA", ZipCode = "11223" };
        Event outdoor = new OutdoorGathering("Picnic", "Community picnic", DateTime.Now.AddDays(2), "12:00 PM", outdoorAddress, "Sunny");

        PrintEventDetails(lecture);
        PrintEventDetails(reception);
        PrintEventDetails(outdoor);
    }

    private static void PrintEventDetails(Event eventObj)
    {
        Console.WriteLine(eventObj.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(eventObj.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(eventObj.GetShortDescription());
        Console.WriteLine(new string('-', 50));
    }
}