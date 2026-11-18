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
        ShowSpinner(3);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine();
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
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