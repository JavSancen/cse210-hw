public class Assignment
{
    private string _studentName;
    protected string _topic; // Changing this to protected

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"Student Name: {_studentName}, Topic: {_topic}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    // Since _topic is now protected, I might not need this method anymore
    // because derived classes can access _topic directly
    protected string GetTopic()
    {
        return _topic;
    }
}