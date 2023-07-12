namespace foundation3
{
public class Event
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private TimeSpan _time;
        private Address _address;

    public Event (string title, string description, DateTime date, TimeSpan time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

    public string GetStandardDetails()
        {
            // Generate event details standard message
            return $"Title: {_title}\n Description: {_description} \nDate: {_date.ToShortDateString()}\nTime: {_time.ToString(@"hh\:mm")}\nAddress: {_address.GetFullAddress()}";   
        }

    public virtual string GetFullDetails()
        {
            // Full details are same as the standard details
                return GetStandardDetails();
        }

    public virtual string GetShortDescription()
        {
            // Create short event description message
            return $"Type: Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";

        }
    }
}