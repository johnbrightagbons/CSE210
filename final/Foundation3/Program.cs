using foundation3;

class Program
{
    static void Main(string[] args)
    {
        // Create Addresses
        Address address1 = new Address("123 Upper Sopkonba Road, Benin City, Edo State, Nigeria", "123 Upper Sopkonba Road", "Benin City", "Edo State", "ED", "Nigeria");
        Address address2 = new Address("2 Park Ave, Los Angeles, CA, USA", "2 Park Ave", "Los Angeles", "California", "CA", "USA");
        Address address3 = new Address("105 Independence st, Benin City, Edo State, Nigeria", "105 Independence St", "Benin City", "Edo State", "ED", "Nigeria");


    // Create Events
        Event lectureEvent = new Lecture("Conference Keynote", "Speech about technology advancements", DateTime.Parse("11-07-2023"), TimeSpan.Parse("10:00"), address1, "John Bright", 100);
        Event receptionEvent = new Reception("Networking Reception", "Casual gathering to connect with industry professionals", DateTime.Parse("12-07-2023"), TimeSpan.Parse("18:00"), address2, "bright@gmail.com");
        Event outdoorGatheringEvent = new OutdoorGathering("Summer Picnic", "Enjoy a day of outdoor activities and food", DateTime.Parse("15-07-2023"), TimeSpan.Parse("12:00"), address3, "Sunny with a high of 25°C");

    // Show Event Details
    Console.WriteLine ("Lecture Full Details: ");
    Console.WriteLine (lectureEvent.GetFullDetails());
    Console.WriteLine();

    Console.WriteLine ("Standard Reception Details: ");
    Console.WriteLine (receptionEvent.GetStandardDetails());
    Console.WriteLine ();

    Console.WriteLine ("Short Description of Outdoor Gathering: ");
    Console.WriteLine (outdoorGatheringEvent.GetShortDescription());
    Console.WriteLine();
    }
}