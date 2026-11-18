//ADDED ABILTY TO TRACK TOTAL SESSION TIME AND LOG ACTIVITIES COMPLETED
using System;
class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;
        int _sessionTime = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Show session activity log");
            Console.WriteLine("  5. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine() ?? "";

            Console.Clear();
            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                _sessionTime += activity.GetDuration();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                _sessionTime += activity.GetDuration();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                _sessionTime += activity.GetDuration();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("Session Activity Log");
                Console.WriteLine();
                Console.WriteLine($"Breathing activities completed: {breathingCount}");
                Console.WriteLine($"Reflection activities completed: {reflectionCount}");
                Console.WriteLine($"Listing activities completed: {listingCount}");
                Console.WriteLine($"Total session time: {_sessionTime} seconds");
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, 3, 4, or 5.");
                Thread.Sleep(2000);
            }
        }

    }
}