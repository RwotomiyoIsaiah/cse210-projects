public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random;
    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. GO!!")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _random = new Random();
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Respond to the Following prompts:");
        Console.WriteLine();
        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < futureTime)
        {
            string prompt = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine($"Question: {prompt}");
            Console.WriteLine();
            
            while(DateTime.Now < futureTime){
                string answer;
                Console.Write("(type 'end' when finished) Answer: ");
                answer = Console.ReadLine() ?? "";
                if (answer == "end")
                {
                    break;
                }else if (!string.IsNullOrWhiteSpace(answer))
                {
                    items.Add(answer);
                }
                DateTime? endTime=futureTime;
                if (endTime.HasValue && DateTime.Now >= endTime.Value)
                {
                    break;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You listed {items.Count} items.");

        DisplayEndingMessage();
    }
}