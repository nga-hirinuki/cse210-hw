public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment(string studentName, string topic, string textbookSection, string problem) : base(studentName, topic) 
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    public string TextbookSection
    {
        get { return _textbookSection; }
        set { _textbookSection = value; }
    }
    public string Problem
    {
        get { return _problem; }
        set { _problem = value; }
    }

    public string GetHomeworkList()
    {
        return 
        "Student Name: " + StudentName + "\n" +
        "Topic: " + Topic + "\n" +
        "Textbook Section: " + TextbookSection + "\n" +
        "Problem: " + Problem + "\n";
        
    }
    
        
}

