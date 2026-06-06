using Mindfulness;

ActivityLog log = new ActivityLog();

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Mindfulness App ===\n");
    Console.WriteLine("Menu Options:");
    Console.WriteLine("  1. Breathing Activity");
    Console.WriteLine("  2. Reflection Activity");
    Console.WriteLine("  3. Listing Activity");
    Console.WriteLine("  4. View Activity Log");
    Console.WriteLine("  5. Quit");
    Console.WriteLine();
    Console.Write("Select an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();
            log.RecordActivity(breathing.GetName(), breathing.GetDurationSeconds());
            break;

        case "2":
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.Run();
            log.RecordActivity(reflection.GetName(), reflection.GetDurationSeconds());
            break;

        case "3":
            ListingActivity listing = new ListingActivity();
            listing.Run();
            log.RecordActivity(listing.GetName(), listing.GetDurationSeconds());
            break;

        case "4":
            log.DisplayLog();
            break;

        case "5":
            Console.WriteLine("\nGoodbye! Keep up the good work.");
            return;

        default:
            Console.WriteLine("Invalid option. Press Enter to try again.");
            Console.ReadLine();
            break;
    }
}