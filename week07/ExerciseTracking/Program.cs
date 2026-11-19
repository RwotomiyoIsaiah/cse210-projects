using System;
using System.Collections.Generic;

namespace ExerciseTracking;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        //instances of each activity
        Running running = new Running("03 Nov 2022", 30, 3.0);
        StationaryBicycle cycling = new StationaryBicycle("03 Nov 2022", 45, 12.0);
        Swimming swimming = new Swimming("03 Nov 2022", 40, 30);
        // Add activities to the list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        // Display summary 
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}