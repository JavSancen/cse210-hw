using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 11, 11), 20, 2.0),
            new Cycling(new DateTime(2024, 11, 12), 30, 15.0),
            new Swimming(new DateTime(2024, 11, 13), 25, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}