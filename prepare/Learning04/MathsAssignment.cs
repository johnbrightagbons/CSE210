public class MathsAssignment : Assignment
{
    private string _textbookChapter;
    private string question;


    public MathsAssignment(string name, string topic, string textbookChapter, string questions): base(name, topic)
    {
        _textbookChapter = textbookChapter;
        question = questions;
    }

    public string GetHomework()
    {
        return $"Chapter {_textbookChapter} Questions {question}";
    }
}