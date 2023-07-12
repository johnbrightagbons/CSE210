using foundation3;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }   

    public override string GetFullDetails()
    { 
        // Create full detail meassage for lecture
        string baseDetails = base.GetFullDetails();  // Get the base event details
        return $"{baseDetails}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}