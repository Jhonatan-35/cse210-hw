using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 03), 30, 3.0));
        activities.Add(new Running(new DateTime(2022, 11, 03), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2022, 11, 03), 45, 30.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 03), 60, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}