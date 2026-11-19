public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);
            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            ShowCountDown(2);
        }

        DisplayEndingMessage();
    }
}