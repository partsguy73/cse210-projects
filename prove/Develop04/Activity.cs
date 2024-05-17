using System;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Starting {_name} activity.");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Duration: {_duration} minutes");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"{_name} complete");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
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
    }
}