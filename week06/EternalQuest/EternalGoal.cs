namespace EternalQuest;

public class EternalGoal : Goal
{
     public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points; 
    }

    public override bool IsComplete() => false; 

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()}:{GetDescription()}:{_points}";
    }
}
