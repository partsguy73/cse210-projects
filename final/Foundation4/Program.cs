using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");

        var activities = new List<Activity>
        {
            new Running(DateTime.Parse("2024-06-03"), 30, 3.0),
            new Cycling(DateTime.Parse("2024-06-03"), 30, 6.0),
            new Swimming(DateTime.Parse("2024-06-03"), 30, 4)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}