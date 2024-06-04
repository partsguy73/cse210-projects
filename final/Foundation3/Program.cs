using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");

        Address address1 = new Address("123 Main St", "Seattle", "WA", "USA");
        Address address2 = new Address("456 Elm Ave", "New York", "NY", "USA");
        Address address3 = new Address("789 Park Rd", "Los Angeles", "CA", "USA");

        Lecture lecture1 = new Lecture("Tech Talk", "Advance AI", DateTime.Now.AddDays(7), TimeSpan.FromHours(14), address1, "Dr. Smith", 100);
        Reception reception1 = new Reception("Networking Mixer", "Meet and Greet", DateTime.Now.AddDays(14), TimeSpan.FromHours(18), address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Picnic", "Family Fun", DateTime.Now.AddDays(21), TimeSpan.FromHours(12), address3, "Sunny with a chance of meatballs");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine(outdoorGathering1.GetShortDescription());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine(outdoorGathering1.GetFullDetails());

        Console.WriteLine("\nShortDescription:");
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine(outdoorGathering1.GetShortDescription());
    }
}