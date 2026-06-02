namespace Homework;

public class WritingAssignment : Assignment

{
    private string _title;
    
    public WritingAssignment(string title, string StudentNamename, string topic)
        :base(StudentNamename, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string StudentName = GetStudentName();

        return $"{_title} by {StudentName}";
   }
}

