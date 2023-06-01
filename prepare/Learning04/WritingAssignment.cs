public class WritingAssignment : Assignment
{
    private string _bookTitle;

    public WritingAssignment (string name, string topic, string _bookTitle) : base(name, topic)
    {
        _bookTitle = bookTitle;
    }

    public string GetWritingDetails()
    {
        string name = GetName();
        return $"{_bookTitle} by {name}";
    }
    

}