using System.Runtime.Intrinsics.Arm;

namespace EternalQuest;

public abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    public Goal(string shortName, string description, int points){
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetShortName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public void SetShortName(string name) => _shortName = name;
    public void SetDescription(string desc) => _description = desc;

    public abstract int RecordEvent();

    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} {_description}";
    }

    public abstract string GetStringRepresentation();
}