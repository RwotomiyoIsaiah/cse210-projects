public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for thsi session? ");
        string input = Console.ReadLine() ?? "0";
        _duration = int.Parse(input);
        Console.WriteLine();
        Console.WriteLine("Get ready...");

        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        Console.Write("Returning to menu "); ShowSpinner(3);
        Console.WriteLine();
    }
    public void ShowSpinner(int seconds, DateTime? endTime = null)//null such that it doesnt break if its is not declared
    {
    List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
    DateTime spinnerEndTime = DateTime.Now.AddSeconds(seconds);

    int i = 0;
    while (DateTime.Now < spinnerEndTime)
    {
        // Stop immediately if the overall activity time has expired
        if (endTime.HasValue && DateTime.Now >= endTime.Value)
        {
            break;
        }
        string s = animationStrings[i];
        Console.Write(s);
        Thread.Sleep(50); 
        Console.Write("\b \b");
        i++;
        if (i >= animationStrings.Count)
        {
            i = 0;
        }
    };
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Done");
    }
    public int GetDuration()
    {
        return _duration;
    }
}