public class WritingAssignment : Assignment
{
    private string bookTitle;

    public WritingAssignment (string name, string topic, string bookTitles) : base(name, topic)
    {
        bookTitle = bookTitles;
    }

    public string GetWritingDetails()
    {
        string name = GetName();
        return $"{bookTitle} by {name}";
    }
    

}