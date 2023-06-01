public class Assignment // A class called assignment
{
    private string _name;  // An attribute called name
    private string _topic; // An attribute called topic


    // Constructors
    public Assignment (string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    // Set getter
    public string GetName ()
    {
        return _name;
    }

    public string GetTopic ()
    {
        return _topic;
    }

    public string GetSummary ()
    {
        return _name + "--" + _topic;
    }
}