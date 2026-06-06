namespace Mindfulness;

public class ActivityLog
{
   private const string LogFilePath = "activity_log.txt";
    private List<string> _entries;

    public ActivityLog()
    {
        _entries = new List<string>();
        LoadFromFile();
    }

       public void RecordActivity(string activityName, int durationSeconds)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string entry = $"[{timestamp}] {activityName} — {durationSeconds} seconds";
        _entries.Add(entry);
        SaveToFile();
    }

    public void DisplayLog()
    {
        Console.Clear();
        Console.WriteLine("=== Activity Log ===");

        if (_entries.Count == 0)
        {
            Console.WriteLine("No activities recorded yet.");
        }
        else
        {
            foreach (string entry in _entries)
                Console.WriteLine(entry);

            Console.WriteLine($"\nTotal activities completed: {_entries.Count}");
        }

        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }

        private void LoadFromFile()
    {
        if (File.Exists(LogFilePath))
        {
            _entries = new List<string>(File.ReadAllLines(LogFilePath));
        }
    }

    private void SaveToFile()
    {
        File.WriteAllLines(LogFilePath, _entries);
    }
}