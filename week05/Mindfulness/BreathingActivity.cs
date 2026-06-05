namespace Mindfulness;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
    "This activity will help you relax by walking you through breathing in and out slowly. " +
               "Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_durationSeconds);
        bool breatheIn = true;

        while (DateTime.Now < end)
        {
            if (breatheIn)
                Console.WriteLine("Breathe in...");
            else
                Console.WriteLine("Breathe out...");

            ShowCountdown(4);
            breatheIn = !breatheIn;
        }
        DisplayEndingMessage();
    }
}