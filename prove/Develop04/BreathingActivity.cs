using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        base.DisplayStartMessage();
        for (int i = 0; i < base._duration; i++)
        {
            Console.WriteLine("Breathe in...");
            base.ShowCountDown(5);
            Console.WriteLine("Hold...");
            base.ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            base.ShowCountDown(5);
            Console.WriteLine("Hold...");
            base.ShowCountDown(5);
        }
    }
}