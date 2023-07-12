using foundation3;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)

            {
                _rsvpEmail = rsvpEmail;
            }

            public override string GetFullDetails()
            {
                // Create full details message for reception
                string baseDetails = base.GetFullDetails(); // Get the base event
                return $"{baseDetails}\nType: Reception\nRSVP E-Mail: {_rsvpEmail}";
            }
    
}