using System.ComponentModel;
using System.Drawing;

namespace EternalQuest;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int  _bonusPoints;

    public ChecklistGoal (string shortName, string description, int points, int targetCount, int bonusPoints)
    : base (shortName, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

   public ChecklistGoal(string shortName, string description, int points,
                         int targetCount, int bonusPoints, int timesCompleted)
        : base(shortName, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("This goal is already complete!!! She's you're the best.");
        }

        _timesCompleted ++;

        if (IsComplete())
        
            return _points + _bonusPoints;

        return _points;
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetShortName()} ({GetDescription()}) -- Completed {_timesCompleted} {_targetCount} times.";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()}:{GetDescription()}:{_points}:{_targetCount}:{_bonusPoints}:{_timesCompleted}";
    }
    
}