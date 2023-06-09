public class Assignment // A class called assignment
{
    private string _name;  // An attribute called name
    private string topicS; // An attribute called topic


    // Constructors
    public Assignment (string name, string topics)
    {
        _name = name;
        topicS = topics;
    }

    // Set getter
    public string GetName ()
    {
        return _name;
    }

    public string GetTopic ()
    {
        return topicS;
    }

    public string GetSummary ()
    {
        return _name + "--" + topicS;
    }
}