using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, List<string> prompts)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _count = _prompts.Count;
    }

    public void Run()
    {
        base.DisplayStartMessage();
        for (int i = 0; i < _count; i++)
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"Prompt {i + 1}: {prompt}");
            List<string> list = GetListFromUser();
            Console.WriteLine("Items:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Enter three items:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Item {i + 1}: ");
            string item = Console.ReadLine();
            items.Add(item);
        }
        return items;
    }
}