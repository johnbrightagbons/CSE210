using foundation3;

class OutdoorGathering : Event
{
    private string _weatherForecast;

     public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            // Create full details message for outdoor gathering
            string baseDetails = base.GetFullDetails(); // Get the base event details
              return $"{baseDetails}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
        }
}


