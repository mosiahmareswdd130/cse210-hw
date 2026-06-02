namespace Homework;

public class Assignment
{
    private string _StudentName;
    private string _topic;

    public Assignment(string StudentNamename, string topic){
        _StudentName = StudentNamename;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _StudentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
       return _StudentName + " - " + _topic;  
    }
}