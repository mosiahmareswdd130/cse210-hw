using System.Runtime.InteropServices.Marshalling;

namespace EternalQuest;

public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    private static readonly(int threshold, string title)[] _levels = new[]
    {
        (0,     "Novice"),
        (1000,  "Bronze Adventurer"),
        (2500,  "Silver Adventurer"),
        (5000,  "Gold Adventurer"),
        (10000, "Platinum Champion"),
        (20000, "Diamond Legend"),
        (50000, "Eternal Master")
    };

    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while(running)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

     public void DisplayPlayerInfo()
    {
        string level = GetCurrentLevel();
        Console.WriteLine($"\nYou are a {level} with a score of {_score} points.");
    }


    private string GetCurrentLevel()
    {
        string title = _levels[0].title;
        foreach (var (threshold, levelTitle) in _levels)
        {
            if (_score >= threshold)
                title = levelTitle;
        }
        return title;
    }


    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"  {i + 1}. {_goals[i].GetShortName()}");
    }


    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet. Create one first!");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? "";

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine() ?? "";

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine() ?? "0");

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine() ?? "1");
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine() ?? "0");
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }


    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record. Create one first!");
            return;
        }

        Console.WriteLine("Which goal did you accomplish?");
        ListGoalNames();
        Console.Write("Select a goal: ");

        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Goal goal = _goals[index - 1];
        string oldLevel = GetCurrentLevel();

        int earned = goal.RecordEvent();
        _score += earned;

        Console.WriteLine($"\nCongratulations! You earned {earned} points!");

        string newLevel = GetCurrentLevel();
        if (newLevel != oldLevel)
            Console.WriteLine($"*** You leveled up! You are now a {newLevel}! ***");
    }


    public void SaveGoals()
    {
        Console.Write("What is the filename for the save file? ");
        string filename = Console.ReadLine() ?? "goals.txt";

        List<string> lines = new List<string>();
        lines.Add(_score.ToString());

        foreach (Goal goal in _goals)
            lines.Add(goal.GetStringRepresentation());

        File.WriteAllLines(filename, lines);
        Console.WriteLine("Goals saved successfully!");
    }


    public void LoadGoals()
    {
        Console.Write("What is the filename for the save file? ");
        string filename = Console.ReadLine() ?? "goals.txt";

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string goalType = parts[0];

            switch (goalType)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2],
                        int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2],
                        int.Parse(parts[3]), int.Parse(parts[4]),
                        int.Parse(parts[5]), int.Parse(parts[6])));
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}