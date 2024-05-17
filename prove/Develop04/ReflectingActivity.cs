using System;
using System.Collections.Generic;
using System.Threading;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
        _random = new Random();
    }

    public void Run()
    {
        base.DisplayStartMessage();
        DisplayPrompt();
        DisplayQuestion();
        base.ShowSpinner(base._duration);
        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"Question: {question}");
    }
}