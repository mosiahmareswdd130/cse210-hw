namespace Homework;

public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string StudentName, string topic, string textbookSection, string problems)
        :base(StudentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return$"Section{_textbookSection} Problems {_problems}";
    }
}