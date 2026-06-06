namespace Mindfulness;

public class ListingActivity : Activity
{
    private static readonly List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private readonly Random _random = new();

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you " +
               "list as many things as you can in a certain area.")
    {
    }

  public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("You have a few seconds to start thinking...");
        ShowCountdown(5);

        Console.WriteLine("\nStart listing items (press Enter after each one):");

        List<string> items = new();
        DateTime end = DateTime.Now.AddSeconds(_durationSeconds);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string? item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        DisplayEndingMessage();
    }
    
}