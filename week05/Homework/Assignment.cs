using System.Dynamic;

public class Assignment 
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // properties
    public string StudentName
    {
        get { return _studentName; }
        set { _studentName = value; }
    }
    public string Topic
    {
        get { return _topic; }
        set { _topic = value; }
    }

    public string GetSummary()
    {
        return $"Assignment for {StudentName} on {Topic}";
    }

}                