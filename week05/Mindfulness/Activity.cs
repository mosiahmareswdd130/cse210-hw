namespace Mindfulness;

public class Activity
{
    private string _name;
    private string _description;
    protected int _durationSeconds;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName() => _name;
    public int GetDurationSeconds() => _durationSeconds;

    public void DisplayStartingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"===_name===");
        Console.WriteLine("_description");
        Console.WriteLine("");
        Console.WriteLine("How long would you like this activity to last? (seconds): ");
        _durationSeconds = int.Parse(Console.ReadLine()?? "10");
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! Keep it up!!!");
        ShowSpinner(3);
        Console.WriteLine("You have completed the {_name} activity for {_durationSeconds} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write($"\r{frames[i % frames.Length]} ");
            Thread.Sleep(200);
            i++;
        }
        Console.Write("\r  \r"); // clear the spinner
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}... ");
            Thread.Sleep(1000);
        }
        Console.Write("\r      \r");
    }

}